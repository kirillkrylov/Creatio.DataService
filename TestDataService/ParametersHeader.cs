using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataService
{
    public class ParametersHeader
    {
        public ParametersHeader()
        {
            line_items = new List<ParameterLine>();
        }

        public string to_street { get; set; }
        public string to_city { get; set; }
        public string to_state { get; set; }
        public string to_zip { get; set; }
        public string to_country { get; set; } = "US";
        public string shipping { get; set; }
        public string customer_code_string { get; set; }
        public string PoNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string currencyCode { get; set; } = "USD";






        public List<ParameterLine> line_items { get; set; }
    }
}
