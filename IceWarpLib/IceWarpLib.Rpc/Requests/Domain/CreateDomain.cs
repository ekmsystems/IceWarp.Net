using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Creates the domain on IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#CreateDomain">https://www.icewarp.co.uk/api/#CreateDomain</see></para>
    /// </summary>
    public class CreateDomain : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// New domain name
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Specifies the domain properties you want to store upon creating the domain
        /// </summary>
        public TPropertyValueList DomainProperties { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (DomainProperties != null)
            {
                commandParams.AppendChild(DomainProperties.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainProperties)));
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
