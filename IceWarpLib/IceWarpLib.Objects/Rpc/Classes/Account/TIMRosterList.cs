using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Instant messaging roster list
    /// </summary>
    public class TIMRosterList : BaseClass
    {
        /// <summary>
        /// List Of TIMRosterItem. See <see cref="TIMRosterItem"/> for more information.
        /// </summary>
        public List<TIMRosterItem> Items { get; set; }
        
        public TIMRosterList()
        {
            Items = new List<TIMRosterItem>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TIMRosterList(XmlNode node)
        {
            Items = new List<TIMRosterItem>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TIMRosterItem(item));
                }
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, "item"));
            }

            return element;
        }
    }
}
