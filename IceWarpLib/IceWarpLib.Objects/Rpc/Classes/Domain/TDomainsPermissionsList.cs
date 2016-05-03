using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// List of TDomainsAdministrativePermissionsSet.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainsPermissionsList">https://www.icewarp.co.uk/api/#TDomainsPermissionsList</see></para>
    /// </summary>
    public class TDomainsPermissionsList : RpcBaseClass
    {
        /// <summary>
        /// List Of TDomainsAdministrativePermissionsSet. See <see cref="TDomainsAdministrativePermissionsSet"/> for more information.
        /// </summary>
        public List<TDomainsAdministrativePermissionsSet> Items { get; set; }

        /// <inheritdoc />
        public TDomainsPermissionsList()
        {
            Items = new List<TDomainsAdministrativePermissionsSet>();
        }

        /// <inheritdoc />
        public TDomainsPermissionsList(XmlNode node)
        {
            Items = new List<TDomainsAdministrativePermissionsSet>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TDomainsAdministrativePermissionsSet(item));
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
