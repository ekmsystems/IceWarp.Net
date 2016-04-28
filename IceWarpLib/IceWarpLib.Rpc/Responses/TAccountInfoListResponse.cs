using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Informational list of accounts.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountsInfoList">https://www.icewarp.co.uk/api/#TAccountsInfoList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAccountsInfoList">https://www.icewarp.co.uk/api/#GetAccountsInfoList</seealso></para>
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

        /// <inheritdoc />
        public TAccountInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TAccountInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
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
