using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// This encapsulates permissions defined on domains. It can contain data related to particular domain and it can also contain data related to multiple domains (using wildcard)
    /// </summary>
    public class TDomainsAdministrativePermissionsSet : BaseClass
    {
        public TDomainsSet DomainsSet { get; set; }
        public TDomainsAdministrativePermissions DomainsAdministrativePermissions { get; set; }
        
        public TDomainsAdministrativePermissionsSet()
        {
            
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainsAdministrativePermissionsSet(XmlNode node)
        {
            if (node != null)
            {
                DomainsSet = new TDomainsSet(node.GetSingleNode("DomainsSet"));
                DomainsAdministrativePermissions = new TDomainsAdministrativePermissions(node.GetSingleNode("DomainsAdministrativePermissions"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(DomainsSet.BuildXmlElement(doc, "DomainsSet"));
            element.AppendChild(DomainsAdministrativePermissions.BuildXmlElement(doc, "DomainsAdministrativePermissions"));

            return element;
        }
    }
}
