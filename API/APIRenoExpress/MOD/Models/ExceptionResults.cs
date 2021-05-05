using System;
using System.Runtime.Serialization;

namespace MOD.RenoExpress
{
    public class ExceptionResults : Exception
    {
        public string ErrorResult { get; set;}

        public ExceptionResults()
        {
        }

        public ExceptionResults(string message) : base(message)
        {
        }

        public ExceptionResults(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ExceptionResults(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
