using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Informational list of rules.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRulesInfoList ">https://www.icewarp.co.uk/api/#TRulesInfoList </see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetRulesInfoList">https://www.icewarp.co.uk/api/#GetRulesInfoList</seealso></para>
    /// </summary>
    public class TRulesInfoListResponse : IceWarpResponse
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
        /// List Of TRuleInfo. See <see cref="TRuleInfo"/> for more information.
        /// </summary>
        public List<TRuleInfo> Items { get; set; }

        /// <inheritdoc />
        public TRulesInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TRuleInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Offset)));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => OverallCount)));
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TRuleInfo(item));
                    }
                }
            }
        }
    }
}
