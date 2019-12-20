using System;

namespace Creatio.DataService
{
    public class BaseExpression
    {
        public const int PrimaryColumnMacrosType = 34;
        public const int PrimaryDisplayColumnMacrosType = 35;
        public const int PrimaryImageColumnMacrosType = 36;
        public BaseExpression() { }

        public Enums.EntitySchemaQueryExpressionType ExpressionType { get; set; }

        public bool ShouldSerializeColumnPath()
        {
            return (!String.IsNullOrEmpty(ColumnPath));
        }
        public string ColumnPath { get; set; }

        public bool ShouldSerializeParameter()
        {
            return (Parameter != null);
        }
        public Parameter Parameter { get; set; }

        public bool ShouldSerializeFunctionType()
        {
            return (FunctionType != Enums.FunctionType.None);
        }
        public Enums.FunctionType FunctionType { get; set; }

        public bool ShouldSerializeMacrosType()
        {
            return (MacrosType != Enums.EntitySchemaQueryMacrosType.None);
        }
        public Enums.EntitySchemaQueryMacrosType MacrosType { get; set; }

        public bool ShouldSerializeFunctionArgument()
        {
            return (FunctionArgument != null);
        }
        public BaseExpression FunctionArgument { get; set; }

        public bool ShouldSerializeDatePartType()
        {
            return (DatePartType != Enums.DatePart.None);
        }
        public Enums.DatePart DatePartType { get; set; }

        public bool ShouldSerializeAggregationType()
        {
            return (AggregationType != Enums.AggregationType.None);
        }
        public Enums.AggregationType AggregationType { get; set; }


        public bool ShouldSerializeAggregationEvalType()
        {
            return (AggregationEvalType != Enums.AggregationEvalType.None);
        }
        public Enums.AggregationEvalType AggregationEvalType { get; set; }


        public bool ShouldSerializeSubFilters()
        {
            return (SubFilters != null);
        }
        public Filters SubFilters { get; set; }
    }
}
