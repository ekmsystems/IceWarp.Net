using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Responses
{
    public class SuccessResponse : IceWarpResponse
    {
        /// <summary>
        /// True if the command was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="IceWarpResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public SuccessResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult){}

        public override void ProcessResultNode(XmlNode node)
        {
            Success = Extensions.GetNodeInnerTextAsBool(node);
        }
    }
}
