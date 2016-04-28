using System;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Services;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Statistic values for service of type SType.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceStatistics">https://www.icewarp.co.uk/api/#TServiceStatistics</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetServiceStatistics">https://www.icewarp.co.uk/api/#GetServiceStatistics</seealso></para>
    /// </summary>
    public class TServiceStatisticsResponse : IceWarpResponse
    {
        public TServiceStatistics Statistics { get; set; }
        
        /// <inheritdoc />
        public TServiceStatisticsResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }


        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                var className = Extensions.GetNodeInnerText(node.GetSingleNode(XmlHelper.ClassNameTag));
                if (!String.IsNullOrEmpty(className))
                {
                    var classType = ClassHelper.TServiceStatisticsClasses()
                                               .FirstOrDefault(x => x.ClassName.ToLower() == className.ToLower());
                    if (classType != null)
                    {
                        Statistics = (TServiceStatistics)ClassHelper.GetInstance(classType.AssemblyQualifiedName);
                    }
                }
            }
        }
    }
}
