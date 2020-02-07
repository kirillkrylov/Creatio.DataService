using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Creatio.DataService
{
    class DataServiceSelectResponseTemplate
    {

        [JsonProperty("rowConfig")]
        public JObject RowConfig { get; set; }

        [JsonProperty("rows")]
        public JArray Rows { get; set; }

        [JsonProperty("notFoundColumns")]
        public string[] NotFoundColumns { get; set; }

        [JsonProperty("rowsAffected")]
        public int RowsAffected { get; set; }

        [JsonProperty("nextPrcElReady")]
        public bool NextPrcElReady { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        public DataTable Table { get; set; }
    }
}
