using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Gets the list of domain api variables, its values, data types and rights. See <see cref="IceWarpCommand{TPropertyInfoList}"/> for return type.
    /// </summary>
    public class GetDomainAPIConsole : IceWarpCommand<TPropertyInfoListResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Filter for domain api variables. See <see cref="TPropertyListFilter"/> for more information.
        /// </summary>
        public TPropertyListFilter Filter { get; set; }
        /// <summary>
        /// Specifies offset start of returned items.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Specifies count of returned items.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Specifies whether return comments or not
        /// </summary>
        public bool Comments { get; set; }

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
            XmlHelper.AppendTextElement(commandParams, "comments", Comments.ToBitString());

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TPropertyInfoListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TPropertyInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyInfoListResponse(httpRequestResult);
        }
    }
}
