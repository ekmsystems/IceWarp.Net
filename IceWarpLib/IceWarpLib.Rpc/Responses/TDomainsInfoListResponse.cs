using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Informational list of domains.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainsInfoList">https://www.icewarp.co.uk/api/#TDomainsInfoList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetDomainsInfoList">https://www.icewarp.co.uk/api/#GetDomainsInfoList</seealso></para>
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

        /// <inheritdoc />
        public TDomainsInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TDomainInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
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
