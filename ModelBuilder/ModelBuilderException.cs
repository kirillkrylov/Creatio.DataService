using System;

namespace ModelBuilder
{
    class ModelBuilderException : Exception
    {
        public ModelBuilderException() { }
        public ModelBuilderException(string message) : base(message) { }
        public ModelBuilderException(string message, Exception inner) : base(message, inner) { }
        protected ModelBuilderException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
