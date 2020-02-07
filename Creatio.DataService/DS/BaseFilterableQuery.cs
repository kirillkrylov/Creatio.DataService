namespace Creatio.DataService
{
    public abstract class BaseFilterableQuery : BaseQuery
    {
        protected BaseFilterableQuery() { }
        public abstract Enums.QueryType QueryType { get; }
        public Filters Filters { get; set; }
    }
}
