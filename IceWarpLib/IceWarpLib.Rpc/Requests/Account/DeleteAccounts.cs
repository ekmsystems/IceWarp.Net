using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes the list of accounts in specified IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#DeleteAccounts">https://www.icewarp.co.uk/api/#DeleteAccounts</see></para>
    /// </summary>
    public class DeleteAccounts : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }

        /// <summary>
        /// StringList of accounts you want to delete. See <see cref="TPropertyStringList"/> for more information.
        /// </summary>
        public TPropertyStringList AccountList { get; set; }

        /// <summary>
        /// Specifies if all account related data should be deleted or not
        /// </summary>
        public bool LeaveData { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            commandParams.AppendChild(AccountList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => AccountList)));
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => LeaveData), LeaveData);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
