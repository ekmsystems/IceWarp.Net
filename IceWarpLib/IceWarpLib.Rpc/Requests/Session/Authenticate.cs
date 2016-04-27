using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Session
{
    /// <summary>
    /// Authenticates user in IceWarp server and creates his session.
    /// <para><see href="https://www.icewarp.co.uk/api/#Authenticate">https://www.icewarp.co.uk/api/#Authenticate</see></para>
    /// </summary>
    public class Authenticate : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Type of authentication. See <see cref="TAuthType"/> for more information.
        /// </summary>
        public TAuthType AuthType { get; set; }
        /// <summary>
        /// Account username or email address - depends on server login policy
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Account plain text password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Account encrypted password
        /// </summary>
        public string Digest { get; set; }
        /// <summary>
        /// Specifies the session expiration - 1 day or 24 days
        /// </summary>
        public bool PersistentLogin { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AuthType), AuthType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Email), Email);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Password), Password);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Digest), Digest);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => PersistentLogin), PersistentLogin);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
