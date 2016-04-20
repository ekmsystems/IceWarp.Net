using System.Collections.Generic;
using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// List of TDomainsAdministrativePermissionsSet
    /// </summary>
    public class TDomainsPermissionsList : BaseClass
    {
        /// <summary>
        /// List Of TDomainsAdministrativePermissionsSet. See <see cref="TDomainsAdministrativePermissionsSet"/> for more information.
        /// </summary>
        public List<TDomainsAdministrativePermissionsSet> Items { get; set; }

        public TDomainsPermissionsList()
        {
            Items = new List<TDomainsAdministrativePermissionsSet>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainsPermissionsList(XmlNode node)
        {
            Items = new List<TDomainsAdministrativePermissionsSet>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TDomainsAdministrativePermissionsSet(item));
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
