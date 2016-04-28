using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Services;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents the list of IceWarp services.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServicesInfoList">https://www.icewarp.co.uk/api/#TServicesInfoList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetServicesInfoList">https://www.icewarp.co.uk/api/#GetServicesInfoList</seealso></para>
    /// </summary>
    public class TServicesInfoListResponse : IceWarpResponse
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
        /// List Of TServiceInfo. See <see cref="TServiceInfo"/> for more information.
        /// </summary>
        public List<TServiceInfo> Items { get; set; }

        /// <inheritdoc />
        public TServicesInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TServiceInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TServiceInfo(item));
                    }
                }
            }
        }
    }
}
