namespace Creatio.DataService
{
    public class BaseQueryColumn : ObjectCollectionItem
    {
        public BaseQueryColumn() { }

        public ColumnExpression Expression { get; set; }
    }
}
