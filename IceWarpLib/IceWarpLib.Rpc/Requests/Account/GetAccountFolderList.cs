using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the list of IMAP and GroupWare folders in specified IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountFolderList">https://www.icewarp.co.uk/api/#GetAccountFolderList</see></para>
    /// </summary>
    public class GetAccountFolderList : IceWarpCommand<TFolderInfoResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// If set to true ,only default folders are returned
        /// </summary>
        public bool OnlyDefault { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => OnlyDefault), OnlyDefault);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TFolderInfoResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TFolderInfoResponse(httpRequestResult);
        }
    }
}
