[![Logo](https://www.creatio.com/sites/default/files/2019-10/creatio-main-logo.svg)](https://github.com/sindresorhus/awesome#readme)
# Creatio DataService

- Install NuGet Package
```C#
Install-Package Creatio.DataService
```

## Usage

To use this package you need to first generate models. use [CLIO][clio] tool to generate models. 
```PowerShell
$ clio modes -e ENV -d C:\Models;
```

-<details>
<symmary>Simple Query</summary>

```C#
    using Creatio.DataService;
    using Creatio.DataService.Models;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {
                Utils utils = Utils.Instance;
                utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    ContactById(utils.CurrentUser.Contact.Value);
                }
                await utils.LoginAsync();
                utils.Dispose();
            }
        }

        private static void ContactById(string ContactId) 
        {
            Contact currentUser = new Contact() { Id = Guid.Parse(ContactId) };
            
            currentUser.ExpandValues();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("-------------- CURRENT USER SelectById --------------");
            Console.WriteLine($"Id:\t\t {currentUser.Id.ToString().Trim()}");
            Console.WriteLine($"Name:\t\t {currentUser.Name ?? currentUser.NameEng}");
            Console.WriteLine($"Email:\t\t {currentUser.Email}");
            Console.WriteLine($"CreatedOn:\t {currentUser.CreatedOn.ToString("dd-MMM-yyyy").Trim()}");
            Console.ResetColor();
            Console.WriteLine();

            currentUser.ExpandAllAssociations(nameof(currentUser.ContactAddressByContact));

            foreach (ContactAddress address in currentUser.ContactAddressByContact) 
            {
                Console.WriteLine(address.Address);
            }
        }

        private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
            Console.ResetColor();
        }
    }

```
</details>





### Ad hoc Query
```C#
private static async Task AdHocQuery() 
{
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
```

### Get List All Entities
```C#
private static async Task AllContacts()
{
    Utils utils = Utils.Instance;
    Console.WriteLine("----------- ALL CONTACTS -----------");
    List<Contact> contacts = await utils.Select<Contact>();
    foreach (Contact contact in contacts)
    {
        Console.WriteLine();
        Console.WriteLine($"Id: {ccontact.Id}");
        Console.WriteLine($"Name: {ccontact.Name}");
        Console.WriteLine($"Email: {ccontact.Email}");
        Console.WriteLine($"CreatedOn: {ccontact.CreatedOn}");
    }
    Console.WriteLine("----------- END OF ALL CONTACTS -----------");
}
```

### Build Select Query
```C#
private static SelectQuery BuildContactQuery() 
{
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
```





[clio]: https://github.com/Advance-Technologies-Foundation/clio