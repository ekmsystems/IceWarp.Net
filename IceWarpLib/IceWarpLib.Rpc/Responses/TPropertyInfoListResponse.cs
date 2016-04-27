using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents the list of properties returned in API Console
    /// </summary>
    public class TPropertyInfoListResponse : IceWarpResponse
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
        /// List Of TPropertyInfo. See <see cref="TPropertyInfo"/> for more information.
        /// </summary>
        public List<TPropertyInfo> Items { get; set; }
        
        public TPropertyInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyInfo(item));
                    }
                }
            }
        }
    }
}
