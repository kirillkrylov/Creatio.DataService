using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Creatio.DataService
{
    public class ObjectCollection<T>
    {
        public ObjectCollection() { }

        [DataMember(Name = "items")]
        public Dictionary<string, T> Items { get; set; }
    }
}
