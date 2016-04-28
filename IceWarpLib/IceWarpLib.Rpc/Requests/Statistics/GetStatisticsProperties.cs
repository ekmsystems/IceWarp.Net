using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Statistics;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Statistics
{
    /// <summary>
    /// Gets server statistic properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetStatisticsProperties">https://www.icewarp.co.uk/api/#GetStatisticsProperties</see></para>
    /// </summary>
    public class GetStatisticsProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// List of statistics properties you want to retrieve
        /// </summary>
        public TStatisticsPropertyList StatisticsPropertyList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            if (StatisticsPropertyList != null)
            {
                commandParams.AppendChild(StatisticsPropertyList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => StatisticsPropertyList)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        /// <returns>Statistics property list with its rights and values. <see cref="TPropertyValueListResponse"/></returns>
        public override TPropertyValueListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyValueListResponse(httpRequestResult);
        }
    }
}
