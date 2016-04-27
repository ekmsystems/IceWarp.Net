using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Get the list of informations about accounts in specified IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountsInfoList">https://www.icewarp.co.uk/api/#GetAccountsInfoList</see></para>
    /// </summary>
    public class GetAccountsInfoList : IceWarpCommand<TAccountInfoListResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Account list filter. See <see cref="TAccountListFilter"/> for more information.
        /// </summary>
        public TAccountListFilter Filter { get; set; }
        /// <summary>
        /// Specifies offset start of returned items.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Specifies count of returned items.
        /// </summary>
        public int Count { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Offset), Offset);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TAccountInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAccountInfoListResponse(httpRequestResult);
        }
    }
}
