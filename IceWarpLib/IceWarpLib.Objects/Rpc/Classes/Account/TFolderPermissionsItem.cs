using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Folder permission item.
    /// <para><see href="https://www.icewarp.co.uk/api/#TFolderPermissionsItem">https://www.icewarp.co.uk/api/#TFolderPermissionsItem</see></para>
    /// </summary>
    public class TFolderPermissionsItem : RpcBaseClass
    {
        /// <summary>
        /// IceWarp account email address
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Permissions for Account
        /// </summary>
        public string Permissions { get; set; }

        /// <inheritdoc />
        public TFolderPermissionsItem()
        {
        }

        /// <inheritdoc />
        public TFolderPermissionsItem(XmlNode node)
        {
            if (node != null)
            {
                Account = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Account)));
                Permissions = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Permissions)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Account), Account);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Permissions), Permissions);

            return element;
        }
    }
}
