using System;

namespace Creatio.DataService.Attributes
{
    public class CObjectAttribute : Attribute
    {
        public string RootSchemaName { get; set; } = "";
    }
}
