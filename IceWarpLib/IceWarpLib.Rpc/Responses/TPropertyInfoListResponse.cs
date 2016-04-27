using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents the list of properties returned in API Console.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyInfoList">https://www.icewarp.co.uk/api/#TPropertyInfoList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAccountAPIConsole">https://www.icewarp.co.uk/api/#GetAccountAPIConsole</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetDomainAPIConsole">https://www.icewarp.co.uk/api/#GetDomainAPIConsole</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetServerAPIConsole">https://www.icewarp.co.uk/api/#GetServerAPIConsole</seealso></para>
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

        /// <inheritdoc />
        public TPropertyInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
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
