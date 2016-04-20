using System.Collections.Generic;
using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Responses
{
    /// <summary>
    /// Informational list of accounts
    /// </summary>
    public class TAccountInfoListResponse : IceWarpResponse
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
        /// List Of TAccountInfo. See <see cref="TAccountInfo"/> for more information.
        /// </summary>
        public List<TAccountInfo> Items { get; set; }
        
        public TAccountInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TAccountInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Offset"));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("OverallCount"));
                var items = node.GetNodes("item");
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TAccountInfo(item));
                    }
                }
            }
        }

    }
}
