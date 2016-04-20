using System;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Exceptions
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
