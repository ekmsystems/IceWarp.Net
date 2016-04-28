using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Result of a check if specified IceWarp service is running
    /// <para><see href="https://www.icewarp.co.uk/api/#IsServiceRunning">https://www.icewarp.co.uk/api/#IsServiceRunning</see></para>
    /// </summary>
    public class IsServiceRunningResponse : IceWarpResponse
    {
        /// <summary>
        /// True if the service is running.
        /// </summary>
        public bool IsRunning { get; set; }

        /// <inheritdoc />
        public IsServiceRunningResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult) { }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            IsRunning = Extensions.GetNodeInnerTextAsBool(node);
        }
    }
}
