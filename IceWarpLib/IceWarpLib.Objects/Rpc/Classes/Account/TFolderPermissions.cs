using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// List of permissions related to specific folder in IceWarp account
    /// </summary>
    public class TFolderPermissions : BaseClass
    {
        /// <summary>
        /// Inherited rights from higher level
        /// </summary>
        public bool IsInherited { get; set; }

        public List<TFolderPermissionsItem> Items { get; set; }

        public TFolderPermissions()
        {
            Items = new List<TFolderPermissionsItem>();
        }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TFolderPermissions(XmlNode node)
        {
            Items = new List<TFolderPermissionsItem>();
            if (node != null)
            {
                IsInherited = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("IsInherited"));
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TFolderPermissionsItem(item));
                }
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            //XmlHelper.AppendTextElement(element, "IsInherited", IsInherited);
            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, "item"));
            }

            return element;
        }
    }
}
