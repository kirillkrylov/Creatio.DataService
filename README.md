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

<details>
<summary>Insert new record</summary>

```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    Contact contact = new Contact() { 

                        Name = "Test Insert new record 4- Kirill",
                        MobilePhone = "+1(555) 555-555",
                        Email = "email@domain.ca"                 
                    };
                    var response = await contact.InsertAsync();
                    Guid NewRecord = response.Result.Id;
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>

<details>
<summary>Update record</summary>

```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    
                    Guid.TryParse(utils.CurrentUser.Contact.Value, out Guid contactToUpdate);
                    Contact contact = new Contact() { Id = contactToUpdate };

                    contact.Email = "your.new.email@domain.ca";
                    var response = await contact.UpdateAsync()
                    int rowsUpdate = response.Result.RowsAffected;
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>

<details>
<summary>Delete record</summary>
```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    
                    var response = await contact.InsertAsync(){Id = Guid.Parse("YOUR_CONTACT_ID_HERE")};
                    var response = await contact.DeleteEntityAsync();
                    int rowsDeleted = response.Result.RowsAffected;
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>


<details>
<summary>View Record</summary>

```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    
                    Guid.TryParse(utils.CurrentUser.Contact.Value, out Guid contactToView);
                    Contact contact = new Contact() { Id = contactToView };

                    await contact.ExpandValuesAsync();
                    await contact.ExpandNavAsync();
                    await contact.ExpandAssociationsAsync();
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>


<details>
<summary>Upload Attachment</summary>

```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    
                    string filePath = @"C:\myImage.gif";
                    FileInfo fileInfo = new FileInfo(filePath);
                    var fileBytes = await System.IO.File.ReadAllBytesAsync(fileInfo.FullName);

                    var r = await utils.UploadFileAsync(fileBytes, $"image/{fileInfo.Extension}", 
                    fileInfo.Name, nameof(Contact), contact.Id.ToString(), "ContactFile", "Data");
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>


<details>
<summary>Update Contact Photo</summary>

```C#
    namespace TestDataService
    {
        public sealed class Program
        {
            public static async Task Main(string[] args)
            {            
                Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
                Utils utils = Utils.Instance;
                if (await utils.LoginAsync())
                {
                    utils.WebSocketMessageReceived += WebSocketMessageReceived;
                    
                    string filePath = @"C:\myImage.gif";
                    FileInfo fileInfo = new FileInfo(filePath);
                    var fileBytes = await System.IO.File.ReadAllBytesAsync(fileInfo.FullName);
                    
                    // Step 1: Upload Image to use
                    var rr = await utils.UploadFileAsync(f, $"image/{fileInfo.Extension}", fileInfo.Name, null, null, null, null);

                    //Step 2: Set PhotoId
                    contact.PhotoId = rr.Result.Id;

                    //Step3: Update contact
                    await contact.UpdateAsync();
                }
                Console.ReadLine();
                await utils.LogoutAsync();
                utils.Dispose();
            }
            private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
                Console.ResetColor();
            }
        }
    }
```
</details>


[clio]: https://github.com/Advance-Technologies-Foundation/clio