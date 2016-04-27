using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Generated password of existing IceWarp account according to current Password policy
    /// <para><see href="https://www.icewarp.co.uk/api/#GenerateAccountPassword">https://www.icewarp.co.uk/api/#GenerateAccountPassword</see></para>
    /// </summary>
    public class GeneratedPasswordResponse : IceWarpResponse
    {
        /// <summary>
        /// Generated password
        /// </summary>
        public string Password { get; set; }

        /// <inheritdoc />
        public GeneratedPasswordResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult) { }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Password = Extensions.GetNodeInnerText(node);
        }
    }
}
