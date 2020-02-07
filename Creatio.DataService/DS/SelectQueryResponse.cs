using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [DataContract]
    public class SelectQueryResponse : BaseResponse
    {
        public SelectQueryResponse() { }

        [DataMember(Name = "rowConfig")]
        public Dictionary<string, object> RowConfig { get; set; }
        [DataMember(Name = "rows")]
        public EntityCollection Rows { get; set; }
        [DataMember(Name = "notFoundColumns")]
        public string[] NotFoundColumns { get; set; }
    }
}
