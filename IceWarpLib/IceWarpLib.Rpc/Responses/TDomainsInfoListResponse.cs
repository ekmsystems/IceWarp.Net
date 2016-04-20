using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Informational list of domains
    /// </summary>
    public class TDomainsInfoListResponse : IceWarpResponse
    {
        /// <summary>
        /// Current offset in the list.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Overall count of domains in the list.
        /// </summary>
        public int OverallCount { get; set; }
        /// <summary>
        /// List Of TDomainInfo. See <see cref="TDomainInfo"/> for more information.
        /// </summary>
        public List<TDomainInfo> Items { get; set; }
        
        public TDomainsInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TDomainInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Offset"));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("OverallCount"));
                var items = node.GetNodes("item");
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TDomainInfo(item));
                    }
                }
            }
        }
    }
}
