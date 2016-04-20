using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// This encapsulates permisions which can be defined FOR certain entity
    /// </summary>
    public class TAdministrativePermissions : BaseClass
    {
        /// <summary>
        /// permissions defined on domain level
        /// </summary>
        public TDomainsPermissionsList DomainsPermissions { get; set; }
        /// <summary>
        /// permissions defined on global level
        /// </summary>
        public TAdministrativePermissionsList GlobalPermissions { get; set; }

        public TAdministrativePermissions()
        {
            DomainsPermissions = new TDomainsPermissionsList();
            GlobalPermissions = new TAdministrativePermissionsList();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAdministrativePermissions(XmlNode node)
        {
            if (node != null)
            {
                DomainsPermissions = new TDomainsPermissionsList(node.GetSingleNode("DomainsPermissions"));
                GlobalPermissions = new TAdministrativePermissionsList(node.GetSingleNode("GlobalPermissions"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(DomainsPermissions.BuildXmlElement(doc, "DomainsPermissions"));
            element.AppendChild(GlobalPermissions.BuildXmlElement(doc, "GlobalPermissions"));

            return element;
        }
    }
}
