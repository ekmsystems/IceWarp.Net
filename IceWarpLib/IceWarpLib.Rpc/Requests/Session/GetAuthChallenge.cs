using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Session
{
    /// <summary>
    /// Get the challenge string for RSA authentication type.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAuthChallenge">https://www.icewarp.co.uk/api/#GetAuthChallenge</see></para>
    /// </summary>
    public class GetAuthChallenge : IceWarpCommand<TAuthChallengeResponse>
    {
        /// <summary>
        /// Type of authentication. See <see cref="TAuthType"/> for more information.
        /// </summary>
        public TAuthType AuthType { get { return TAuthType.Rsa; } }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AuthType), AuthType);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TAuthChallengeResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAuthChallengeResponse(httpRequestResult);
        }
    }
}
