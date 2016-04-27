using System.Xml;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Session
{
    /// <summary>
    /// Get info about active session.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetSessionInfo">https://www.icewarp.co.uk/api/#GetSessionInfo</see></para>
    /// </summary>
    public class GetSessionInfo : IceWarpCommand<TAPISessionInfoResponse>
    {
        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(GetCommandParamsElement(doc));
        }

        /// <inheritdoc />
        public override TAPISessionInfoResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAPISessionInfoResponse(httpRequestResult);
        }
    }
}
