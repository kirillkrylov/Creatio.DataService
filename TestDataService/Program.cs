using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Creatio.DataService;
using Newtonsoft.Json;
using TestDataService.Model;

namespace TestDataService
{
    class Program
    {
        static async Task Main()
        {
            Utils utils = Utils.Instance;
            utils.SetCredentials("Kirill", "111", "https://023879-studio.creatio.com");

            if (await utils.LoginAsync()) {
                utils.WebSocketMessageReceived += WebSocketMessageReceived;

                Console.WriteLine($"You Logged In as: {utils.CurrentUser.Contact.DisplayValue}");
                var ContactId = utils.CurrentUser.Contact.Value;
                await ContactById(ContactId);
                //await AllContacts();
                //await AdHocQuery();
            }
            Console.ReadLine();
            utils.Dispose();
        }

        private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You've got message: { e.MessageBody}");
            Console.ResetColor();
        }

        private static async Task ContactById(string ContactId) {

            Contact currentUser = new Contact() { Id = Guid.Parse(ContactId) };
            currentUser = await currentUser.Expnad<Contact>(currentUser.Id);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("----------- CURRENT USER SelectById -----------");
            Console.WriteLine($"Id: {currentUser.Id}");
            Console.WriteLine($"Name: {currentUser.Name}");
            Console.WriteLine($"Email: {currentUser.Email}");
            Console.WriteLine($"CreatedOn: {currentUser.CreatedOn}");
            Console.WriteLine($"Account: {currentUser.Account.Id}");
            
            Utils utils = Utils.Instance;
            currentUser.Activities = await utils.SelectList<Activity>("Owner", currentUser.Id);
            foreach (Activity activity in currentUser.Activities) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine($"\tTitle:{activity.Title} Start:{activity.StartDate} Ends:{activity.DueDate}");
                Console.WriteLine($"Count of Activities: {currentUser.Activities.Count}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------- END OF CURRENT USER -----------");
            Console.ResetColor();
            

            Account account = await currentUser.Account.Expnad<Account>(currentUser.Account.Id);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("----------- CURRENT USER / Account -----------");
            Console.WriteLine($"Id: {account.Id}");
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Phone: {account.Phone}");
            Console.WriteLine($"Web: {account.Web}");
            Console.WriteLine($"PrimaryContact: {account.PrimaryContact.Id}");
            Console.WriteLine("----------- END OF CURRENT USER / Account-----------");
            Console.ResetColor();

            
            Contact primaryContact = await account.Expnad<Contact>(account.PrimaryContact.Id);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("----------- CURRENT USER / Account / PrimaryContact -----------");
            Console.WriteLine($"Id: {primaryContact.Id}");
            Console.WriteLine($"Name: {primaryContact.Name}");
            Console.WriteLine($"Phone: {primaryContact.Email}");
            Console.WriteLine("----------- END OF CURRENT USER  / Account / PrimaryContact-----------");
            Console.ResetColor();
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
