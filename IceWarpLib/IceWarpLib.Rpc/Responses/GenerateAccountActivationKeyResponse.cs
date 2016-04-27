using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Generated activation key for IceWarp account
    /// <para><see href="https://www.icewarp.co.uk/api/#GenerateAccountActivationKey">https://www.icewarp.co.uk/api/#GenerateAccountActivationKey</see></para>
    /// </summary>
    public class GenerateAccountActivationKeyResponse : IceWarpResponse
    {
        /// <summary>
        /// Activation Key string
        /// </summary>
        public string ActivationKey { get; set; }

        /// <inheritdoc />
        public GenerateAccountActivationKeyResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult) { }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            ActivationKey = Extensions.GetNodeInnerText(node);
        }
    }
}
