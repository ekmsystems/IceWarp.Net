using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes all accounts that matches current filter in specified IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#DeleteAllAccounts">https://www.icewarp.co.uk/api/#DeleteAllAccounts</see></para>
    /// </summary>
    public class DeleteAllAccounts : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }

        /// <summary>
        /// Account list filter
        /// </summary>
        public TAccountListFilter Filter { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
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
