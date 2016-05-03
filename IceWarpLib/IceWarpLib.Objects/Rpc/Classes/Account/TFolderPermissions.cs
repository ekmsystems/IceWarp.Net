using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// List of permissions related to specific folder in IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TFolderPermissions">https://www.icewarp.co.uk/api/#TFolderPermissions</see></para>
    /// </summary>
    public class TFolderPermissions : RpcBaseClass
    {
        /// <summary>
        /// Inherited rights from higher level
        /// </summary>
        public bool IsInherited { get; set; }
        /// <summary>
        /// List Of TFolderPermissionsItem. See <see cref="TFolderPermissionsItem"/>
        /// </summary>
        public List<TFolderPermissionsItem> Items { get; set; }

        /// <inheritdoc />
        public TFolderPermissions()
        {
            Items = new List<TFolderPermissionsItem>();
        }

        /// <inheritdoc />
        public TFolderPermissions(XmlNode node)
        {
            Items = new List<TFolderPermissionsItem>();
            if (node != null)
            {
                IsInherited = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => IsInherited)));
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TFolderPermissionsItem(item));
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
