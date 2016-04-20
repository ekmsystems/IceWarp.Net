using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Administrative permissions related to domain and its accounts
    /// </summary>
    public class TDomainsAdministrativePermissions : BaseClass
    {
        public TAdministrativePermissionsList AccountsRelatedPermissions { get; set; }
        public TAdministrativePermissionsList DomainRelatedPermissions { get; set; }

        public TDomainsAdministrativePermissions()
        {
            AccountsRelatedPermissions = new TAdministrativePermissionsList();
            DomainRelatedPermissions = new TAdministrativePermissionsList();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainsAdministrativePermissions(XmlNode node)
        {
            if (node != null)
            {
                AccountsRelatedPermissions = new TAdministrativePermissionsList(node.GetSingleNode("AccountsRelatedPermissions"));
                DomainRelatedPermissions = new TAdministrativePermissionsList(node.GetSingleNode("DomainRelatedPermissions"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(AccountsRelatedPermissions.BuildXmlElement(doc, "AccountsRelatedPermissions"));
            element.AppendChild(DomainRelatedPermissions.BuildXmlElement(doc, "DomainRelatedPermissions"));

            return element;
        }
    }
}
