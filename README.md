[![Logo](https://www.creatio.com/sites/default/files/2019-10/creatio-main-logo.svg)](https://github.com/sindresorhus/awesome#readme)
# Creatio DataService

- Install NuGet Package
```C#
Install-Package Creatio.DataService
```

## Usage
```C#
static async Task Main()
{
    Utils utils = Utils.Instance;
    utils.SetCredentials("yourUserNameHere", "yourPasswordHere", "https://domain.creatio.com");
    if (await utils.LoginAsync()) {
        Console.WriteLine($"You Logged In as: {utils.CurrentUser.Contact.DisplayValue}");
        Guid ContactId = utils.CurrentUser.Contact.Value;
        Console.WriteLine($"Your ContactId is: {ContactId}");
        utils.WebSocketMessageReceived += WebSocketMessageReceived;
        
        await ContactById(ContactId);

        //await AllContacts();
        //await AdHocQuery();
    }
}

![Output](/Img/Out.png)




private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You've got message: { e.MessageBody}");
    Console.ResetColor();
}
```

### Define Contact Model
```C#
using Creatio.DataService.Attributes;
using System;

namespace TestDataService.Model
{
    [RootSchemaName("Contact")]
    class Contact
    {
        [QueryColumn("Id")]
        public Guid Id { get; set; }

        [QueryColumn("Name")]
        public string Name { get; set; }
        
        [QueryColumn("Email")]
        public string Email { get; set; }
        
        [QueryColumn("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [QueryColumn("ModifiedOn")]
        public DateTime ModifiedOn { get; set; }

        [RootSchemaName("Account")]
        public Account Account { get; set; }
    }
}
```

### Define Account Model
```C#
using Creatio.DataService.Attributes;
using System;

namespace TestDataService.Model
{
    [RootSchemaName("Account")]
    class Account
    {
        [QueryColumn("Id")]
        public Guid Id { get; set; }

        [QueryColumn("Name")]
        public string Name { get; set; }

        [QueryColumn("Phone")]
        public string Phone { get; set; }

        [QueryColumn("Web")]
        public string Web { get; set; }

        [RootSchemaName("PrimaryContact")]
        public Contact PrimaryContact { get; set; }
    }
}
```

### Get Entity by Id
```C#
private static async Task ContactById(string ContactId) 
{
    Utils utils = Utils.Instance;
    List<Contact> CurrentUser = await utils.Select<Contact>(ContactId);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("----------- CURRENT USER SelectById -----------");
    Console.WriteLine($"Id: {CurrentUser[0].Id}");
    Console.WriteLine($"Name: {CurrentUser[0].Name}");
    Console.WriteLine($"Email: {CurrentUser[0].Email}");
    Console.WriteLine($"CreatedOn: {CurrentUser[0].CreatedOn}");
    Console.WriteLine($"Account: {CurrentUser[0].Account.Id}");
    Console.WriteLine("----------- END OF CURRENT USER -----------");
    Console.ResetColor();

    List<Account> accounts = await utils.Select<Account>(CurrentUser[0].Account.Id.ToString());
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine();
    Console.WriteLine("----------- CURRENT USER / Account -----------");
    Console.WriteLine($"Id: {accounts[0].Id}");
    Console.WriteLine($"Name: {accounts[0].Name}");
    Console.WriteLine($"Phone: {accounts[0].Phone}");
    Console.WriteLine($"Web: {accounts[0].Web}");
    Console.WriteLine($"Web: {accounts[0].PrimaryContact.Id}");
    Console.WriteLine("----------- END OF CURRENT USER / Account-----------");
    Console.ResetColor();

    List<Contact> primaryContact = await utils.Select<Contact>(accounts[0].PrimaryContact.Id.ToString());
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine();
    Console.WriteLine("----------- CURRENT USER / Account / PrimaryContact -----------");
    Console.WriteLine($"Id: {primaryContact[0].Id}");
    Console.WriteLine($"Name: {primaryContact[0].Name}");
    Console.WriteLine($"Phone: {primaryContact[0].Email}");
    Console.WriteLine("----------- END OF CURRENT USER  / Account / PrimaryContact-----------");
    Console.ResetColor();
}
```

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