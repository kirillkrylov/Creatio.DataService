namespace Creatio.DataService
{
    public class Filters : Filter
    {
        public Filters() { }
        public bool ShouldSerializeRootSchemaName()
        {
            return (!string.IsNullOrEmpty(RootSchemaName));
        }
        public string RootSchemaName { get; set; }
    }
}
