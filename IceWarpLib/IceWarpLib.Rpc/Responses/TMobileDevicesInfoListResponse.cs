using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents the list of mobile devices
    /// <para><see href="https://www.icewarp.co.uk/api/#">https://www.icewarp.co.uk/api/#</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#">https://www.icewarp.co.uk/api/#</seealso></para>
    /// </summary>
    public class TMobileDevicesInfoListResponse : IceWarpResponse
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
        /// List Of TDomainInfo. See <see cref="TMobileDeviceInfo"/> for more information.
        /// </summary>
        public List<TMobileDeviceInfo> Items { get; set; }

        /// <inheritdoc />
        public TMobileDevicesInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TMobileDeviceInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TMobileDeviceInfo(item));
                    }
                }
            }
        }
    }
}
