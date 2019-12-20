namespace Creatio.DataService
{
    public class SelectQuery : BaseFilterableQuery, IReturn<SelectQueryResponse>, IReturn
    {
        public SelectQuery()
        {
            UseMetrics = false;
            QueryOptimize = false;
            RowsOffset = 0;
            RowCount = 20000;
            UseRecordDeactivation = true;
            UseLocalization = true;
            IsPageable = false;
            AllColumns = false;
            QuerySource = 0;
            IsHierarchical = false;
        }
        public bool UseMetrics { get; set; }
        public bool QueryOptimize { get; set; }
        public int RowsOffset { get; set; }
        public bool ShouldSerializeHierarchicalColumnValue()
        {
            return (!string.IsNullOrEmpty(HierarchicalColumnValue));
        }
        public string HierarchicalColumnValue { get; set; }
        public bool ShouldSerializeHierarchicalColumnName()
        {
            return (!string.IsNullOrEmpty(HierarchicalColumnName));
        }
        public string HierarchicalColumnName { get; set; }
        public bool ShouldSerializeHierarchicalMaxDepth()
        {
            return (HierarchicalMaxDepth > 0);
        }
        public int HierarchicalMaxDepth { get; set; }
        public bool IsHierarchical { get; set; }
        public bool ShouldSerializeConditionalValues()
        {
            return (ConditionalValues != null);
        }
        public ColumnValues ConditionalValues { get; set; }
        public int RowCount { get; set; }
        public bool UseRecordDeactivation { get; set; }
        public bool ShouldSerializeUseLocalization()
        {
            return (UseLocalization == true);
        }
        public bool UseLocalization { get; set; }
        public bool ShouldSerializeIsDistinct()
        {
            return (IsDistinct == true);
        }
        public bool IsDistinct { get; set; }
        public bool ShouldSerializeIsPageable()
        {
            return (IsPageable == true);
        }
        public bool IsPageable { get; set; }
        public bool ShouldSerializeServerESQCacheParameters()
        {
            return (ServerESQCacheParameters != null);
        }
        public ServerESQCacheParameters ServerESQCacheParameters { get; set; }
        public bool ShouldSerializeAllColumns()
        {
            return (AllColumns == true);
        }
        public bool AllColumns { get; set; }
        public bool ShouldSerializeColumns()
        {
            return (Columns != null);
        }
        public SelectQueryColumns Columns { get; set; }
        public override Enums.QueryType QueryType { get; }
        public Enums.QuerySource QuerySource { get; set; }
        public bool ShouldSerializeIgnoreDisplayValues()
        {
            return (IgnoreDisplayValues == true);
        }
        /// <summary>
        /// A sign that identifies that the request will not be used to display values of
        /// columns.
        /// 
        /// If this property is true, the query returns the values displayed columns; if
        /// this property is false, the query returns the stored value column.
        /// </summary>
        public bool IgnoreDisplayValues { get; set; }
    }
}
