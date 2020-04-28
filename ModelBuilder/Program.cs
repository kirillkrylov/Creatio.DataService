using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModelBuilder
{
    class Program
    {
        const string clioJson = @"\creatio\clio\appsettings.json";
        public static string requestedEnvironment = string.Empty;
        public static DirectoryInfo destination;

        static async Task Main(string[] args)
        {
            if(args.Length >0) ReadArguments(args);

            Utils utils = Utils.Instance;
            ConsoleWriter.WriteMessage(MessageType.Try, Properties.Resources.buildingMessage);
            try
            {
                utils.ConnectionString = GetConnectionString();
                ConsoleWriter.WriteMessage(MessageType.OK, Properties.Resources.succesConnectionMessage);
            }
            catch (FileNotFoundException e)
            {
                string message = $"{e.Message} File: {e.FileName}";
                ConsoleWriter.WriteMessage(MessageType.Error, message);
                return;
            }

            if (utils.ConnectionString != null)
            {
                ConsoleWriter.WriteMessage(MessageType.Try, $"Attempting to connect to {utils.ConnectionString.Uri}");
                try
                {
                    utils.Login();
                    ConsoleWriter.WriteMessage(MessageType.OK, Properties.Resources.loginSuccessMessage);
                    Console.ForegroundColor = ConsoleColor.Yellow;                    
                    foreach (Cookie cookie in utils.AuthCookieContainer.GetCookies(new Uri(utils.ConnectionString.Uri))) {
                        int length = (cookie.Value.Length > 30) ? 30 : cookie.Value.Length;
                        Console.WriteLine($"\t{cookie.Name}:\t{cookie.Value.Substring(0, length)}");
                    }
                    Console.WriteLine();
                    Console.ResetColor();
                }
                catch (ModelBuilderException e)
                {
                    ConsoleWriter.WriteMessage(MessageType.Error, e.Message);
                    return;
                }
            }
            ConsoleWriter.WriteMessage(MessageType.Try, Properties.Resources.metadataMessage);
            RequestResponse rr = await utils.GetMetadata().ConfigureAwait(false);
            await utils.LogoutAsync().ConfigureAwait(false);

            if (rr.ErrorMessage == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int count = CountXmlLines(rr?.Result??"");

                ConsoleWriter.WriteMessage(MessageType.OK, $"Obtained definition for {count} entities");
                Console.WriteLine($"Would you like to create {count} models? Press any key to continue, <Esc> to exit");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    ConsoleWriter.WriteMessage(MessageType.Info, Properties.Resources.exitMessage);
                }
                else {
                    ConsoleWriter.WriteMessage(MessageType.Info, Properties.Resources.waitMessage);
                    await BuildModels(rr.Result).ConfigureAwait(false);
                }
            }
            else
            {
                ConsoleWriter.WriteMessage(MessageType.Error, rr.ErrorMessage);
                return;
            }
        }

        private static void ReadArguments(string[] args) {

            if (args.Contains("-e"))
            {
                int eIndex = Array.IndexOf(args, "-e");
                if (args.Length - 1 >= eIndex+1) {
                    requestedEnvironment = args[eIndex + 1].ToString(CultureInfo.InvariantCulture);
                }

                int dIndex = Array.IndexOf(args, "-d");
                if (args.Length - 1 >= dIndex + 1)
                {
                    string dest = args[dIndex + 1].ToString(CultureInfo.InvariantCulture);
                    destination = new DirectoryInfo(dest);
                }

            }
        }

        /// <summary>
        /// Get UserName, Password and URI for Clio ActiveEnvironment
        /// </summary>
        /// <returns>object containing credentials/returns>
        private static IConnectionString GetConnectionString() {
            IConnectionString cs = Factory.Create<ConnectionString>();

            string appdata = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}{clioJson}";
            if (!File.Exists(appdata)) {
                throw new FileNotFoundException(Properties.Resources.fileNotFoundMessage, appdata);
            }

            string jsonFile = File.ReadAllText(appdata);
            JObject j = JsonConvert.DeserializeObject<JObject>(jsonFile);          
            JToken activeEnvironmentKey = j.SelectToken("ActiveEnvironmentKey");
            string env = activeEnvironmentKey.Value<string>();

            if (!string.IsNullOrEmpty(requestedEnvironment) || !string.IsNullOrWhiteSpace(requestedEnvironment))
                env = requestedEnvironment;

            cs.Username = j.SelectToken($"Environments.{env}.Login").Value<string>();
            cs.Password = j.SelectToken($"Environments.{env}.Password").Value<string>();
            cs.Uri = j.SelectToken($"Environments.{env}.Uri").Value<string>();
            return cs;
        }
        private static int CountXmlLines(string input) {

            XDocument xDoc = XDocument.Parse(input);

            int q = (from c in xDoc.Descendants()
                     where c.Name.LocalName == "EntityType"
                     select c).Count();
            return q;
        }
        
        /// <summary>
        /// Creates cs files in C:\Models
        /// </summary>
        /// <param name="input">XMl content</param>
        /// <returns></returns>
        private static async Task BuildModels(string input) {

            if (string.IsNullOrEmpty(input))
                return;

            XDocument xDoc = XDocument.Parse(input);
            var nSpace = from c in xDoc.Descendants()
                         where c.Name.LocalName == "Schema"
                         select c.Attribute("Namespace").Value;
            
            //Create Directory
            //string dir = @"C:\Models";
            string dir = destination.FullName;

            Directory.CreateDirectory(dir);

            var associations = (from ent in xDoc.Descendants()
                               where ent.Name.LocalName == "Association"
                               select ent).ToList();


            var entities = from ent in xDoc.Descendants()
                           where ent.Name.LocalName == "EntityType"
                           select ent;

            foreach (XElement entity in entities) {

                IEnumerable<XElement> keys = from key in entities.Descendants()
                           where key.Name.LocalName == "PropertyRef"
                           select key;


                //string className = entity.Attribute("Name").Value;
                //Console.WriteLine(className);

                EntityBuilder eb = Factory.Create<EntityBuilder>();
                BaseModel bm = eb.Build(nSpace.FirstOrDefault(), entity, keys, associations); ;

                string fullPath = $"{dir}\\{bm.Class.Name}.cs";
                await CreateSourceFile(fullPath, bm.ToString()).ConfigureAwait(false);
            }
        }
        private static async Task CreateSourceFile(string fullPath, string content) {

            if (string.IsNullOrEmpty(content) ||  string.IsNullOrEmpty(fullPath))
                return;
            
            using StreamWriter sw = File.CreateText(fullPath);
            try
            {
                await sw.WriteAsync(content).ConfigureAwait(false);
                ConsoleWriter.WriteMessage(MessageType.OK, $"Created: {fullPath}");
            }
            catch (IOException ex)
            {
                ConsoleWriter.WriteMessage(MessageType.Error, ex.Message);
            }
            finally
            {
                await sw.DisposeAsync().ConfigureAwait(false);
            }
        }
    }
}

