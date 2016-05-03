using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Instant messaging roster list.
    /// <para><see href="https://www.icewarp.co.uk/api/#TIMRosterList">https://www.icewarp.co.uk/api/#TIMRosterList</see></para>
    /// </summary>
    public class TIMRosterList : RpcBaseClass
    {
        /// <summary>
        /// List Of TIMRosterItem. See <see cref="TIMRosterItem"/> for more information.
        /// </summary>
        public List<TIMRosterItem> Items { get; set; }

        /// <inheritdoc />
        public TIMRosterList()
        {
            Items = new List<TIMRosterItem>();
        }

        /// <inheritdoc />
        public TIMRosterList(XmlNode node)
        {
            Items = new List<TIMRosterItem>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TIMRosterItem(item));
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
