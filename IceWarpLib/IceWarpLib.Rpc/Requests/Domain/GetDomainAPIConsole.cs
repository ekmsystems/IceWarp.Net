using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Gets the list of domain api variables, its values, data types and rights.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetDomainAPIConsole">https://www.icewarp.co.uk/api/#GetDomainAPIConsole</see></para>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);

            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Offset), Offset);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Comments), Comments);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TPropertyInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyInfoListResponse(httpRequestResult);
        }
    }
}
