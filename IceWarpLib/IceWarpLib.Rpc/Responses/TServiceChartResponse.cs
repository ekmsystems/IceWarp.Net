using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Services;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Statistic values for service of type SType.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceChart">https://www.icewarp.co.uk/api/#TServiceChart</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetTrafficCharts">https://www.icewarp.co.uk/api/#GetTrafficCharts</seealso></para>
    /// </summary>
    public class TServiceChartResponse : IceWarpResponse
    {
        /// <summary>
        /// List of services traffic data
        /// </summary>
        public TSCItmList List { get; set; }

        /// <inheritdoc />
        public TServiceChartResponse(HttpRequestResult httpRequestResult) : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                List = new TSCItmList(node.GetSingleNode(ClassHelper.GetMemberName(() => List)));
            }
        }
    }
}
