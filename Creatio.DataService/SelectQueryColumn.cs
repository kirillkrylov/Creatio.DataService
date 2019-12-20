namespace Creatio.DataService
{
    public class SelectQueryColumn : BaseQueryColumn
    {
        public SelectQueryColumn()
        {
            this.IsVisible = true;
        }

        public bool ShouldSerializeOrderDirection()
        {
            return (OrderDirection != Enums.OrderDirection.None);
        }

        public Enums.OrderDirection OrderDirection { get; set; }

        public bool ShouldSerializeOrderPosition()
        {
            return (OrderPosition != 0);
        }
        public int OrderPosition { get; set; }


        public string Caption { get; set; }
        public bool IsVisible { get; set; }
    }
}
