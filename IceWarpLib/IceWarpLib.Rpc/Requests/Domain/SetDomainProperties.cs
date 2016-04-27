using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Sets the values of domain properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetDomainProperties">https://www.icewarp.co.uk/api/#SetDomainProperties</see></para>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (PropertyValueList != null)
            {
                commandParams.AppendChild(PropertyValueList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyValueList)));
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
