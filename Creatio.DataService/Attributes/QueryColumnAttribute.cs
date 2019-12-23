using System;

namespace Creatio.DataService.Attributes
{
    public class QueryColumnAttribute : Attribute
    {
        public string ColumnPath { get; set; }
        public Enums.EntitySchemaQueryExpressionType ExpressionType { get; set; }
        public Enums.OrderDirection OrderDirection { get; set; }
        public int OrderPosition { get; set; }

        /// <summary>
        /// 
        /// <see cref="https://academy.creatio.com/documents/technic-sdk/7-15/dataservice-reading-records"/>
        /// </summary>
        /// <param name="columnPath">Path to the column in relation to the root schema <see cref=""/></param>
        /// <param name="expressionType">Type of expression that determines the value that the added column will contain.</param>
        /// <param name="orderPosition">Sets position number in the collection of the query columns, by which the sorting is done.</param>
        /// <param name="orderDirection">Sorting order</param>
        public QueryColumnAttribute(string columnPath, Enums.EntitySchemaQueryExpressionType expressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
            int orderPosition = 0, Enums.OrderDirection orderDirection = Enums.OrderDirection.Ascending
            )
        {
            ColumnPath = columnPath;
            ExpressionType = expressionType;
            OrderPosition = orderPosition;
            OrderDirection = orderDirection;
        }
    }
}
