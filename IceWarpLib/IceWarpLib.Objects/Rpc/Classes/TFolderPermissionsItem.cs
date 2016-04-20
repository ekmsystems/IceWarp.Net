using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Folder permission item
    /// </summary>
    public class TFolderPermissionsItem : BaseClass
    {
        /// <summary>
        /// IceWarp account email address
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Permissions for Account
        /// </summary>
        public string Permissions { get; set; }
        
        public TFolderPermissionsItem()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TFolderPermissionsItem(XmlNode node)
        {
            if (node != null)
            {
                Account = Extensions.GetNodeInnerText(node.GetSingleNode("Account"));
                Permissions = Extensions.GetNodeInnerText(node.GetSingleNode("Permissions"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Account", Account);
            XmlHelper.AppendTextElement(element, "Permissions", Permissions);

            return element;
        }
    }
}
