using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Gets the properties of the existing IceWarp domain. See <see cref="IceWarpCommand{TPropertyValueList}"/> for return type.
    /// </summary>
    public class GetDomainProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// Domain name
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Specifies the domains properties you want to get rights for
        /// </summary>
        public TDomainPropertyList DomainPropertyList { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "domainstr", DomainStr);
            if (DomainPropertyList != null)
            {
                commandParams.AppendChild(DomainPropertyList.BuildXmlElement(doc, "domainpropertylist"));
            }

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TPropertyValueListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TPropertyValueListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyValueListResponse(httpRequestResult);
        }
    }
}
