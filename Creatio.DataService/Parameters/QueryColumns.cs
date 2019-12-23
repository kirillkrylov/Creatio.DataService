using System;
using System.Collections.Generic;
using System.Text;

namespace Creatio.DataService.Parameters
{
    class QueryColumn
    {

        public string Caption { get; set; }
        public string ColumnPath { get; set; }
        public Enums.EntitySchemaQueryExpressionType ExpressionType { get; set; }
        public Enums.OrderDirection OrderDirection { get; set; }
        public int OrderPosition { get; set; }
    }
}
