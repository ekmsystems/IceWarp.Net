using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// A generic successful response from IceWarp
    /// </summary>
    public class SuccessResponse : IceWarpResponse
    {
        /// <summary>
        /// True if the command was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <inheritdoc />
        public SuccessResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult){}

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Success = Extensions.GetNodeInnerTextAsBool(node);
        }
    }
}
