using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Represents the list of folders in IceWarp account
    /// </summary>
    public class TFolderInfoList : BaseClass
    {
        /// <summary>
        /// List Of TFolderInfo. See <see cref="List{TFolderInfo}"/> for more information.
        /// </summary>
        public List<TFolderInfo> Items { get; set; }
        
        public TFolderInfoList()
        {
            Items = new List<TFolderInfo>();
        }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TFolderInfoList(XmlNode node)
        {
            Items = new List<TFolderInfo>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TFolderInfo(item));
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
