using Creatio.DataService;
using Creatio.DataService.Attributes;
using System;
using System.Collections.Generic;

namespace TestDataService.Model
{
    [RootSchemaName("Contact")]
    class Contact : BaseEntity
    {

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

        [RootSchemaName("Activity")]
        public List<Activity> Activities { get; set; }
    }
}
