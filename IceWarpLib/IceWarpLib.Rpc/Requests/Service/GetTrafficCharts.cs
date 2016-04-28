using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Service
{
    /// <summary>
    /// Gets the traffic chart data for specified IceWarp service.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetTrafficCharts">https://www.icewarp.co.uk/api/#GetTrafficCharts</see></para>
    /// </summary>
    public class GetTrafficCharts : IceWarpCommand<TServiceChartResponse>
    {
        /// <summary>
        /// Service type specification
        /// </summary>
        public TServiceType SType { get; set; }
        /// <summary>
        ///  Type of traffic chart data
        /// </summary>
        public TServiceChartType ChartType { get; set; }
        /// <summary>
        /// Number of points on x asis
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Interval Length
        /// </summary>
        public TServiceChartPeriod Period { get; set; }
        /// <summary>
        /// Optional interval start
        /// </summary>
        public string FFrom { get; set; }
        /// <summary>
        /// Optional interval end
        /// </summary>
        public string FTo { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => SType), SType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => ChartType), ChartType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Period), Period);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => FFrom), FFrom);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => FTo), FTo);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        /// <returns>Traffic charts. See <see cref="TServiceChartResponse"/></returns>
        public override TServiceChartResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TServiceChartResponse(httpRequestResult);
        }
    }
}
