﻿using Creatio.DataService;
using Creatio.DataService.Models;
using System;
using System.Threading.Tasks;
using TestDataService.Properties;

namespace TestDataService
{
    public sealed class Program
    {
        public static async Task Main()
        {
            Utils utils = Utils.Instance;
            utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);

            if (await utils.LoginAsync()) {
                Console.WriteLine($"You Logged In as: {utils.CurrentUser.Contact.DisplayValue}");
                utils.WebSocketMessageReceived += WebSocketMessageReceived;
                Console.WriteLine("I have subscribed to WebSoketMessages");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();
                var ContactId = utils.CurrentUser.Contact.Value;
                await ContactById(ContactId);
            }

            Console.ReadLine();
            utils.Dispose();
        }

        private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
            Console.ResetColor();
        }

        private static async Task ContactById(string ContactId) {
            Contact currentUser = new Contact() { Id = Guid.Parse(ContactId)};
            currentUser = await currentUser.Expnad<Contact>(currentUser.Id);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------- CURRENT USER SelectById --------------");
            Console.WriteLine($"Id:\t\t {currentUser.Id.ToString().Trim()}");
            Console.WriteLine($"Name:\t\t {currentUser.Name.Trim()}");
            Console.WriteLine($"Email:\t\t {currentUser.Email.Trim()}");
            Console.WriteLine($"CreatedOn:\t {currentUser.CreatedOn.ToString("dd-MMM-yyyy").Trim()}");
            Console.ResetColor();
            Console.WriteLine();

            currentUser.ExpandAllAssociations(nameof(currentUser.ContactCommunicationByContact));

            Console.WriteLine("Contact Communication Options");
            Parallel.ForEach(currentUser.ContactCommunicationByContact, i =>
            {
                i.ExpandAllNav(nameof(CommunicationType));
                string line = $"{i.CommunicationType.Name}\t : {i.Number}";
                Console.WriteLine(line);
            });
        }

        /* Unused Methods
        private static async Task AdHocQuery() {

            Utils utils = Utils.Instance;

            SelectQuery select = BuildContactQuery();
            string jsonRequest = JsonConvert.SerializeObject(select);
            RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);
            DataTable dt = utils.ConvertResponseToDataTable(result.Result);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("----------- Ad Hoc Select Query-----------");
            foreach (DataRow dr in dt.Rows) 
            {
                Console.WriteLine($"Id: {dr["Id"]}");
                Console.WriteLine($"Name: {dr["Name"]}");
                Console.WriteLine($"Email: {dr["Email"]}");
                Console.WriteLine($"Phone: {dr["Phone"]}");
                Console.WriteLine($"Account: {dr["Account"]}");
                Console.WriteLine();
            }
        }
        private static async Task AllContacts()
        {
            Utils utils = Utils.Instance;
            Console.WriteLine("----------- ALL CONTACTS -----------");
            List<Contact> contacts = await utils.Select<Contact>();
            foreach (Contact ccontact in contacts)
            {
                Console.WriteLine();
                Console.WriteLine($"Id: {ccontact.Id}");
                Console.WriteLine($"Name: {ccontact.Name}");
                Console.WriteLine($"Email: {ccontact.Email}");
                Console.WriteLine($"CreatedOn: {ccontact.CreatedOn}");
            }
            Console.WriteLine("----------- END OF ALL CONTACTS -----------");
        }

        private static SelectQuery BuildContactQuery() {
            SelectQuery contactQuery = new SelectQuery()
            {
                RootSchemaName = "Contact",
                RowCount = 10,
                RowsOffset = -1,
                QueryKind = Enums.QueryKind.General,
                QuerySource = Enums.QuerySource.Filter,
                UseLocalization = true,
                QueryOptimize = true,
                Columns = new SelectQueryColumns()
                {
                    Items = new Dictionary<string, SelectQueryColumn>()
                    {
                        {
                            "Id", new SelectQueryColumn()
                            {
                                Caption = "Id",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Id"
                                }
                            }
                        },
                        {
                            "Name", new SelectQueryColumn()
                            {
                                Caption = "Name",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Name"
                                }
                            }
                        },
                        {
                            "Email", new SelectQueryColumn()
                            {
                                Caption = "Email",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Email"
                                }
                            }
                        },
                        {
                            "Phone", new SelectQueryColumn()
                            {
                                Caption = "Phone",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Phone"
                                }
                            }
                        },
                        {
                            "Image", new SelectQueryColumn()
                            {
                                Caption = "Image",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Photo.Id"
                                }
                            }
                        },
                        {
                            "Account", new SelectQueryColumn()
                            {
                                Caption = "Account",
                                OrderDirection = Enums.OrderDirection.Ascending,
                                OrderPosition = 0,
                                Expression = new ColumnExpression()
                                {
                                    ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
                                    ColumnPath = "Account"
                                }
                            }
                        }
                    }
                }
            };
            return contactQuery;
        }
        */
    }
}
