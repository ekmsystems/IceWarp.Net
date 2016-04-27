using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Changes the password of existing IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetAccountPassword">https://www.icewarp.co.uk/api/#SetAccountPassword</see></para>
    /// </summary>
    public class SetAccountPassword : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Type of authentication. See <see cref="TAuthType"/> for more information.
        /// </summary>
        public TAuthType AuthType { get; set; }
        /// <summary>
        /// Account plain text password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// RSA encrypted password
        /// </summary>
        public string Digest { get; set; }
        /// <summary>
        /// If set, the process ignores the current password policy
        /// </summary>
        public bool IgnorePolicy { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AuthType), AuthType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Password), Password);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Digest), Digest);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => IgnorePolicy), IgnorePolicy);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
