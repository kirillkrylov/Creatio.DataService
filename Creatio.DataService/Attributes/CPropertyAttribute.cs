using System;

namespace Creatio.DataService.Attributes
{
    public class CPropertyAttribute : Attribute
    {
        public string ColumnPath { get; set; }
        public bool IsKey { get; set; }
        public string Association { get; set; }
        public string Navigation { get; set; }
    }
}
