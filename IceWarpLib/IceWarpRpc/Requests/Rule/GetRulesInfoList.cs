using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Rule
{
    /// <summary>
    /// Get the info list of server, domain or account rules
    /// </summary>
    public class GetRulesInfoList : IceWarpCommand<TRulesInfoListResponse>
    {
        /// <summary>
        /// The value can be email address(account rules), domain name(domain rules) or empty string (server rules)
        /// </summary>
        public string Who { get; set; }
        /// <summary>
        /// Rules list filter. See <see cref="TRulesListFilter"/> for more information.
        /// </summary>
        public TRulesListFilter Filter { get; set; }
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

            XmlHelper.AppendTextElement(commandParams, "Who", Who);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, "Filter"));
            }

            XmlHelper.AppendTextElement(commandParams, "Offset", Offset);
            XmlHelper.AppendTextElement(commandParams, "Count", Count);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TRulesInfoListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TRulesInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TRulesInfoListResponse(httpRequestResult);
        }
    }
}
