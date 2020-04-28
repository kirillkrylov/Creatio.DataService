using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Creatio.DataService.Parameters
{

    class UpdateQueryColumn
    {
        public string ColumnPath { get; set; }
        public Parameter Parameter { get;set;}
        public Enums.EntitySchemaQueryExpressionType ExpressionType { get; set; }
    }
}
