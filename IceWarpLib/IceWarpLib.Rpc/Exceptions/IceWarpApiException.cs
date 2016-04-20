using System;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Exceptions
{
    public class IceWarpApiException : Exception
    {
        public HttpRequestResult HttpRequestResult { get; set; }

        public IceWarpApiException(HttpRequestResult httpRequestResult, Exception innerException)
            : base("An error occurred with the request. See InnerException for more details.", innerException)
        {
            HttpRequestResult = httpRequestResult;
        }

        public IceWarpApiException(string message, HttpRequestResult httpRequestResult, Exception innerException)
            : base(message, innerException)
        {
            HttpRequestResult = httpRequestResult;
        }
    }
}
