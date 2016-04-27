using System.Xml;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Generates a password for an IceWarp account according to current Password policy.
    /// <para><see href="https://www.icewarp.co.uk/api/#GenerateAccountPassword">https://www.icewarp.co.uk/api/#GenerateAccountPassword</see></para>
    /// </summary>
    public class GenerateAccountPassword : IceWarpCommand<GeneratedPasswordResponse>
    {
        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(GetCommandParamsElement(doc));
        }

        /// <inheritdoc />
        public override GeneratedPasswordResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new GeneratedPasswordResponse(httpRequestResult);
        }
    }
}
