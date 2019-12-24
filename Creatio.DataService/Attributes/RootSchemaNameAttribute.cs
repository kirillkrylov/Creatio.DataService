using System;

namespace Creatio.DataService.Attributes
{
    public class RootSchemaNameAttribute : Attribute
    {
        public string RootSchemaName { get; set; }
        public bool UseLocalization { get; set; }
        public bool AllColumns { get; set; }
        public bool AutoExpand { get; set; }

        /// <summary>
        /// 
        /// <see cref="https://academy.creatio.com/documents/technic-sdk/7-15/dataservice-reading-records"/>
        /// </summary>
        /// <param name="rootSchemaName">String that contains root schema name of the record object (table name)</param>
        /// <param name="useLocalization">Defies whether or not values should be localized when possible</param>
        /// <param name="allColumns ">Indicates if all columns are selected. If the value is set to true, all columns of the root schema will be selected by the query.</param>
        public RootSchemaNameAttribute(string rootSchemaName, bool autoExpand=false, bool useLocalization = false, bool allColumns = false)
        {
            RootSchemaName = rootSchemaName;
            UseLocalization = useLocalization;
            AllColumns = allColumns;
            AutoExpand = autoExpand;
        }
    }
}
