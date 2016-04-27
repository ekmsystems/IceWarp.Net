using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Gets the rights for domain properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetMyDomainRigths">https://www.icewarp.co.uk/api/#GetMyDomainRigths</see></para>
    /// </summary>
    public class GetMyDomainRigths : IceWarpCommand<TPropertyRightListResponse>
    {
        /// <summary>
        /// Domain name
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Specifies the domains properties you want to get rights for
        /// </summary>
        public TDomainPropertyList DomainPropertyList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (DomainPropertyList != null)
            {
                commandParams.AppendChild(DomainPropertyList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainPropertyList)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TPropertyRightListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyRightListResponse(httpRequestResult);
        }
    }
}
