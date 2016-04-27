using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Sets the list of permissions for specified folder in existing IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetAccountFolderPermissions">https://www.icewarp.co.uk/api/#SetAccountFolderPermissions</see></para>
    /// </summary>
    public class SetAccountFolderPermissions : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Id of the folder in specified account
        /// </summary>
        public string FolderId { get; set; }
        /// <summary>
        /// List of folder permissions
        /// </summary>
        public TFolderPermissions Permissions { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => FolderId), FolderId);
            if (Permissions != null)
            {
                commandParams.AppendChild(Permissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Permissions)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
