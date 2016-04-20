using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// List of API properties and its permissions
    /// </summary>
    public class TAdministrativePermissionsList : BaseClass
    {
        /// <summary>
        /// List Of TPropertyPermission. See <see cref="TPropertyPermission"/> for more information.
        /// </summary>
        public List<TPropertyPermission> Items { get; set; }

        public TAdministrativePermissionsList()
        {
            Items = new List<TPropertyPermission>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAdministrativePermissionsList(XmlNode node)
        {
            Items = new List<TPropertyPermission>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyPermission(item));
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
