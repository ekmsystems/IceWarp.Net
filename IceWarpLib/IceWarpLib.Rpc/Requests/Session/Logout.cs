using System.Xml;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Session
{
    /// <summary>
    /// Logs the user out and destroy his session.
    /// <para><see href="https://www.icewarp.co.uk/api/#Logout">https://www.icewarp.co.uk/api/#Logout</see></para>
    /// </summary>
    public class Logout : IceWarpCommand<SuccessResponse>
    {
        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(GetCommandParamsElement(doc));
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
