using System;
using System.Collections.Generic;
using System.Text;

namespace ModelBuilder
{
    class ConnectionString : IConnectionString
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Uri { get; set; } = "";
    }
}
