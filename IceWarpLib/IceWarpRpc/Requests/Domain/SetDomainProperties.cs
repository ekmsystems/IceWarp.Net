using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Domain
{
    /// <summary>
    /// Sets the values of domain properties. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
    /// </summary>
    public class SetDomainProperties : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Domain name
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Specifies the list of variables you want to set with its values
        /// </summary>
        public TPropertyValueList PropertyValueList { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "domainstr", DomainStr);
            if (PropertyValueList != null)
            {
                commandParams.AppendChild(PropertyValueList.BuildXmlElement(doc, "propertyvaluelist"));
            }

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="SuccessResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
