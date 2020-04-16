using Avalara.AvaTax.RestClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataService
{
    public class ParameterLine
    {
        public string quantity { get; set; }
        public string unit_price { get; set; }
        public string product_tax_code { get; set; }
        public string id { get; set; }
        public string avaTaxCode { get; set; }
        public decimal taxAmount { get; set; }
        public string description  { get; set; }
        public Sourcing sourcing { get; set; }


    }
}
