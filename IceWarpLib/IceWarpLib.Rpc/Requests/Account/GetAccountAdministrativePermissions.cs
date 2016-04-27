using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the list of permissions for specified folder in existing IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountAdministrativePermissions">https://www.icewarp.co.uk/api/#GetAccountAdministrativePermissions</see></para>
    /// </summary>
    public class GetAccountAdministrativePermissions : IceWarpCommand<TAdministrativePermissionsResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TAdministrativePermissionsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAdministrativePermissionsResponse(httpRequestResult);
        }
    }
}
