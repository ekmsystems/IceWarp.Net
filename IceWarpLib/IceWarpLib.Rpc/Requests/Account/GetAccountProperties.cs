using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the properties of the existing IceWarp account. See <see cref="IceWarpCommand{TPropertyValueList}"/> for return type.
    /// </summary>
    public class GetAccountProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// List of properties you want to get. See <see cref="TAccountPropertyList"/> for more information.
        /// </summary>
        public TAccountPropertyList AccountPropertyList { get; set; }
        /// <summary>
        /// Predefined list of properties
        /// </summary>
        public TAccountPropertySet? AccountPropertySet { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "accountemail", AccountEmail);
            if (AccountPropertyList != null)
            {
                commandParams.AppendChild(AccountPropertyList.BuildXmlElement(doc, "accountpropertylist"));
            }
            XmlHelper.AppendTextElement(commandParams, "accountpropertyset", AccountPropertySet.HasValue ? AccountPropertySet.Value.ToString("d") : TAccountPropertySet.None.ToString("d"));

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
