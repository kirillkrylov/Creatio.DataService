using System;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;

namespace TestDataService
{

    public class USPS
    {
        const string Username = "472BPMON4277";
        //const string Password = "352XR02AD264";
        const string BaseUrl = "https://secure.shippingapis.com/ShippingAPI.dll?API=";

        public static async Task<UspsAddress> ZipCodeLookupAsync(ZipCodeLookupRequest request)
        {
            const string API = "ZipCodeLookup";
            string Url = String.Format("{0}{1}&XML={2}", BaseUrl, API, request.XML);

            string Address1 = "";
            string Address2 = "";
            string City = "";
            string State = "";
            string Zip4 = "";
            string Zip5 = "";
            string errorDescription = "";

            try
            {
                WebRequest wr = WebRequest.Create(Url);
                wr.Timeout = 5000;
                WebResponse response = await wr.GetResponseAsync();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                XDocument ZipCodeLookupResponse = XDocument.Parse(responseFromServer);

                //check for error response from api
                if (ZipCodeLookupResponse.Element("ZipCodeLookupResponse").Element("Address").HasElements)
                {
                    IEnumerable<XElement> collection = ZipCodeLookupResponse.Element("ZipCodeLookupResponse").Element("Address").Elements();
                    foreach (XElement x in collection)
                    {
                        if (x.Name.LocalName == "Address1")
                        {
                            Address1 = x.Value;
                        }
                        else if (x.Name.LocalName == "Address2")
                        {
                            Address2 = x.Value;
                        }
                        else if (x.Name.LocalName == "City")
                        {
                            City = x.Value;
                        }
                        else if (x.Name.LocalName == "State")
                        {
                            State = x.Value;
                        }
                        else if (x.Name.LocalName == "Zip4")
                        {
                            Zip4 = x.Value;
                        }
                        else if (x.Name.LocalName == "Zip5")
                        {
                            Zip5 = x.Value;
                        }
                        else if (x.Name == "Error" && x.HasElements)
                        {
                            foreach (XElement error in x.Elements())
                            {
                                if (error.Name == "Description")
                                {
                                    errorDescription = error.Value;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorDescription = ex.Message;
            }
            //string[] Zip = new string[] { Zip5, Zip4, request.Name, errorDescription };
            UspsAddress result = new UspsAddress
            {
                Name = request.Name,
                Address1 = Address1,
                Address2 = Address2,
                City = City,
                State = State,
                Zip4 = Zip4,
                Zip5 = Zip5,
                ErrorDescription = errorDescription
            };
            return result;
        }

        public class UspsAddress
        {
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip4 { get; set; }
            public string Zip5 { get; set; }
            public string ErrorDescription { get; set; }
        }

        public class ZipCodeLookupRequest
        {
            public string Name { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            public string XML
            {
                get
                {
                    XElement root = new XElement("ZipCodeLookupRequest",
                        new XAttribute("USERID", Username),
                        new XElement("Address",
                            new XElement("Address1", Address1),
                            new XElement("Address2", Address2),
                            new XElement("City", City),
                            new XElement("State", State)
                        )
                    );
                    return root.ToString();
                }
            }
        }
    }

}
