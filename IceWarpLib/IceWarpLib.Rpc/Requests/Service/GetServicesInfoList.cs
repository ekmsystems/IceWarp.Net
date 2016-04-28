using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Services;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Service
{
    /// <summary>
    /// Gets server statistic properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServicesInfoList">https://www.icewarp.co.uk/api/#GetServicesInfoList</see></para>
    /// </summary>
    public class GetServicesInfoList : IceWarpCommand<TServicesInfoListResponse>
    {
        /// <summary>
        /// Services list filter. See <see cref="TServiceListFilter"/> for more information.
        /// </summary>
        public TServiceListFilter Filter { get; set; }
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
        /// <returns>Info list of IceWarp services. See <see cref="TServicesInfoListResponse"/></returns>
        public override TServicesInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TServicesInfoListResponse(httpRequestResult);
        }
    }
}
