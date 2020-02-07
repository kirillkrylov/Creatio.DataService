using System;

namespace Creatio.DataService
{
    public class CreationException : Exception
    {
        public CreationException() { }
        public CreationException(string message) : base(message) { }
        public CreationException(string message, Exception inner) : base(message, inner) { }
        protected CreationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
