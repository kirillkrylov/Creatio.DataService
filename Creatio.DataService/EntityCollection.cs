using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Creatio.DataService
{
    [KnownType(typeof(LookupColumnValue))]
    public class EntityCollection : List<Dictionary<string, object>>
    {
        public EntityCollection() { }
    }
}
