using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Get the informations about domains available in current session.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetDomainsInfoList">https://www.icewarp.co.uk/api/#GetDomainsInfoList</see></para>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Offset), Offset);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TDomainsInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TDomainsInfoListResponse(httpRequestResult);
        }
    }
}
