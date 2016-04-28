using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Service
{
    /// <summary>
    /// Get the statistics for specified IceWarp service
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServiceStatistics">https://www.icewarp.co.uk/api/#GetServiceStatistics</see></para>
    /// </summary>
    public class GetServiceStatistics : IceWarpCommand<TServiceStatisticsResponse>
    {
        /// <summary>
        /// Service type specification
        /// </summary>
        public TServiceType SType { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => SType), SType);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        /// <returns>Statistic values for service of type SType. See <see cref="TServiceStatisticsResponse"/></returns>
        public override TServiceStatisticsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TServiceStatisticsResponse(httpRequestResult);
        }
    }
}
