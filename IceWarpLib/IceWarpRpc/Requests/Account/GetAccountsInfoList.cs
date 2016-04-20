using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    /// <summary>
    /// Get the list of informations about accounts in specified IceWarp domain. See <see cref="IceWarpCommand{TAccountInfoList}"/> for return type.
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

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "domainstr", DomainStr);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, "filter"));
            }
            XmlHelper.AppendTextElement(commandParams, "offset", Offset.ToString());
            XmlHelper.AppendTextElement(commandParams, "count", Count.ToString());

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TAccountInfoListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TAccountInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAccountInfoListResponse(httpRequestResult);
        }
    }
}
