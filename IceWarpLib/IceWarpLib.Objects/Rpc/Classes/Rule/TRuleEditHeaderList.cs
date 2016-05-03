using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// List of header modifications.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleEditHeaderList">https://www.icewarp.co.uk/api/#TRuleEditHeaderList</see></para>
    /// </summary>
    public class TRuleEditHeaderList : RpcBaseClass
    {
        /// <summary>
        /// List Of TRuleEditHeaderItem. <see cref="TRuleEditHeaderItem"/>
        /// </summary>
        public List<TRuleEditHeaderItem> Items { get; set; }

        /// <inheritdoc />
        public TRuleEditHeaderList()
        {
            Items = new List<TRuleEditHeaderItem>();
        }

        /// <inheritdoc />
        public TRuleEditHeaderList(XmlNode node)
        {
            Items = new List<TRuleEditHeaderItem>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TRuleEditHeaderItem(item));
                }
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, XmlHelper.ItemTag));
            }

            return element;
        }
    }
}
