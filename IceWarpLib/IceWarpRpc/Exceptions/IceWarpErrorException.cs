using System;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Exceptions
{
    public class IceWarpErrorException : Exception
    {
        public string IceWarpError { get; set; }
        public HttpRequestResult HttpRequestResult { get; set; }

        public IceWarpErrorException(string iceWarpError, HttpRequestResult httpRequestResult)
        {
            IceWarpError = iceWarpError;
            HttpRequestResult = httpRequestResult;
        }
    }
}
