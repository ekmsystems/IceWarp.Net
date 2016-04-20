using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Get the informations about domains available in current session. See <see cref="IceWarpCommand{TDomainsInfoList}"/> for return type.
    /// </summary>
    public class GetDomainsInfoList : IceWarpCommand<TDomainsInfoListResponse>
    {
        /// <summary>
        /// Domain list filter. See <see cref="TDomainListFilter"/> for more information.
        /// </summary>
        public TDomainListFilter Filter { get; set; }
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
        /// <returns>The response from IceWarp. See <see cref="TDomainsInfoListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TDomainsInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TDomainsInfoListResponse(httpRequestResult);
        }
    }
}
