using System;
using System.Collections.Generic;
using System.Text;

namespace Creatio.DataService
{
    public class Filter
    {
        

        public Filter()
        {
            IsEnabled = true;
        }
        public Enums.LogicalOperationStrict LogicalOperation { get; set; }
        public Enums.FilterComparisonType ComparisonType { get; set; }

        public bool ShouldSerializeIsAggregative()
        {
            return (IsAggregative);
        }
        public bool IsAggregative { get; set; }

        public bool ShouldSerializeKey()
        {
            return (!string.IsNullOrEmpty(Key));
        }
        public string Key { get; set; }

        public bool ShouldSerializeTrimDateTimeParameterToDate()
        {
            return (TrimDateTimeParameterToDate);
        }
        public bool TrimDateTimeParameterToDate { get; set; }

        public bool ShouldSerializeRightGreaterExpression()
        {
            return (RightGreaterExpression != null);
        }
        public BaseExpression RightGreaterExpression { get; set; }

        public bool ShouldSerializeRightLessExpression()
        {
            return (RightLessExpression != null);
        }
        public BaseExpression RightLessExpression { get; set; }

        public bool ShouldSerializeRightExpressions()
        {
            return (RightExpressions != null);
        }
        public BaseExpression[] RightExpressions { get; set; }

        public bool ShouldSerializeRightExpression()
        {
            return (RightExpression != null);
        }
        public BaseExpression RightExpression { get; set; }

        public bool ShouldSerializeLeftExpressionCaption()
        {
            return (LeftExpressionCaption != null);
        }
        public string LeftExpressionCaption { get; set; }

        public bool ShouldSerializeLeftExpression()
        {
            return (LeftExpression != null);
        }
        public BaseExpression LeftExpression { get; set; }

        public bool ShouldSerializeSubFilters()
        {
            return (SubFilters != null);
        }
        public Filters SubFilters { get; set; }

        public bool ShouldSerializeIsNot()
        {
            return (IsNot);
        }
        public bool IsNot { get; set; }


        public bool ShouldSerializeIsEnabled()
        {
            return (IsEnabled);
        }
        public bool IsEnabled { get; set; }

        public bool ShouldSerializeIsNull()
        {
            return (IsNull);
        }
        public bool IsNull { get; set; }

        public bool ShouldSerializeFilterType()
        {
            return (FilterType != Enums.FilterType.None);
        }
        public Enums.FilterType FilterType { get; set; }

        public bool ShouldSerializeItems()
        {
            return (Items != null && Items.Count > 0);
        }
        public Dictionary<string, Filter> Items { get; set; }

        public bool ShouldSerializeReferenceSchemaName()
        {
            return (ReferenceSchemaName != null);
        }
        public string ReferenceSchemaName { get; set; }
    }
}
