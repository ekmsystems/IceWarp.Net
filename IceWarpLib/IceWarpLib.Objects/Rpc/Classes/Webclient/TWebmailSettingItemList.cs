using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Webclient
{
    /// <summary>
    /// List of webclient setting items.
    /// <para><see href="https://www.icewarp.co.uk/api/#TWebmailSettingItemList">https://www.icewarp.co.uk/api/#TWebmailSettingItemList</see></para>
    /// </summary>
    public class TWebmailSettingItemList : RpcBaseClass
    {
        /// <summary>
        /// List Of TWebmailSettingItem. See <see cref="TWebmailSettingItem"/> for more information.
        /// </summary>
        public List<TWebmailSettingItem> Items { get; set; }

        /// <inheritdoc />
        public TWebmailSettingItemList()
        {
            Items = new List<TWebmailSettingItem>();
        }

        /// <inheritdoc />
        public TWebmailSettingItemList(XmlNode node)
        {
            Items = new List<TWebmailSettingItem>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TWebmailSettingItem(item));
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
