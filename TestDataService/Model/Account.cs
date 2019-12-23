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
