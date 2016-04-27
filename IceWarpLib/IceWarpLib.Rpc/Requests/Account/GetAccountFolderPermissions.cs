using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the permission list for the folder specified by account email and folder id.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountFolderPermissions">https://www.icewarp.co.uk/api/#GetAccountFolderPermissions</see></para>
    /// </summary>
    public class GetAccountFolderPermissions : IceWarpCommand<TFolderPermissionsResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Id of the folder in specified account
        /// </summary>
        public string FolderId { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => FolderId), FolderId);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TFolderPermissionsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TFolderPermissionsResponse(httpRequestResult);
        }
    }
}
