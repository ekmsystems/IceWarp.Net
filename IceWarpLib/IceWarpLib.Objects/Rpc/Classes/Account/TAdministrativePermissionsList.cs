using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// List of API properties and its permissions.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAdministrativePermissionsList">https://www.icewarp.co.uk/api/#TAdministrativePermissionsList</see></para>
    /// </summary>
    public class TAdministrativePermissionsList : RpcBaseClass
    {
        /// <summary>
        /// List Of TPropertyPermission. See <see cref="TPropertyPermission"/> for more information.
        /// </summary>
        public List<TPropertyPermission> Items { get; set; }

        public TAdministrativePermissionsList()
        {
            Items = new List<TPropertyPermission>();
        }

        /// <inheritdoc />
        public TAdministrativePermissionsList(XmlNode node)
        {
            Items = new List<TPropertyPermission>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyPermission(item));
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
