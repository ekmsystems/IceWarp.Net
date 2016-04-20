using System;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Exceptions
{
    public class ProcessResponseException : Exception
    {
        public HttpRequestResult HttpRequestResult { get; set; }

        public ProcessResponseException(string message)
            : base(message)
        {
            
        }

        public ProcessResponseException(string message, HttpRequestResult httpRequestResult)
            : base(message)
        {
            HttpRequestResult = httpRequestResult;
        }

        public ProcessResponseException(HttpRequestResult httpRequestResult, Exception innerException)
            : base("An error occurred when processing the response. See InnerException for more details.", innerException)
        {
            HttpRequestResult = httpRequestResult;
        }

        public ProcessResponseException(string message, HttpRequestResult httpRequestResult, Exception innerException)
            : base(message, innerException)
        {
            HttpRequestResult = httpRequestResult;
        }
    }
}
