using System;
using System.Runtime.Serialization;

namespace Creatio.DataService
{
    public class BaseQuery
    {
        public BaseQuery() 
        {
            QueryKind = Enums.QueryKind.General;
        }
        
        /// <summary>
        /// Additional information about the query, that can be used to dispatch the query
        /// to a special Terrasoft.Core.DB.DBExecutor.
        /// </summary>
        public Enums.QueryKind QueryKind { get; set; }

        public bool ShouldSerializeColumnValues()
        {
            return (ColumnValues != null);
        }
        public ColumnValues ColumnValues { get; set; }
        public string RootSchemaName { get; set; }
        
        [IgnoreDataMember]
        [Obsolete]
        public Enums.QueryOperationType OperationType { get; set; }
    }
}
