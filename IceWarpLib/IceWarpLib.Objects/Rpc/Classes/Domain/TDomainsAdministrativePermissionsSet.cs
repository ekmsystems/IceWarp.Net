using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// This encapsulates permissions defined on domains. It can contain data related to particular domain and it can also contain data related to multiple domains (using wildcard).
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainsAdministrativePermissionsSet">https://www.icewarp.co.uk/api/#TDomainsAdministrativePermissionsSet</see></para>
    /// </summary>
    public class TDomainsAdministrativePermissionsSet : RpcBaseClass
    {
        /// <summary>
        /// Set of domains
        /// </summary>
        public TDomainsSet DomainsSet { get; set; }
        /// <summary>
        /// Permissions related to domains in domainsset
        /// </summary>
        public TDomainsAdministrativePermissions DomainsAdministrativePermissions { get; set; }

        /// <inheritdoc />
        public TDomainsAdministrativePermissionsSet()
        {
            
        }

        /// <inheritdoc />
        public TDomainsAdministrativePermissionsSet(XmlNode node)
        {
            if (node != null)
            {
                DomainsSet = new TDomainsSet(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainsSet)));
                DomainsAdministrativePermissions = new TDomainsAdministrativePermissions(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainsAdministrativePermissions)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(DomainsSet.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainsSet)));
            element.AppendChild(DomainsAdministrativePermissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainsAdministrativePermissions)));

            return element;
        }
    }
}
