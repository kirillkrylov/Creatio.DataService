using Creatio.DataService;
using Creatio.DataService.Attributes;

namespace TestDataService.Model
{
    [RootSchemaName("Activity")]
    class Activity : BaseEntity
    {
        [QueryColumn("Title")]
        public string Title { get; set; }

        [QueryColumn("StartDate")]
        public string StartDate { get; set; }

        [QueryColumn("DueDate")]
        public string DueDate { get; set; }

        [RootSchemaName("Owner")]
        public string Owner { get; set; }
    }
}
