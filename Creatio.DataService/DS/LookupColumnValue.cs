using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class LookupColumnValue
    {
        public LookupColumnValue() { }

        [DataMember(Name = "value")]
        public string Value { get; set; }
        [DataMember(Name = "displayValue")]
        public string DisplayValue { get; set; }
        [DataMember(Name = "primaryImageValue")]
        public string PrimaryImageValue { get; set; }
    }
}
