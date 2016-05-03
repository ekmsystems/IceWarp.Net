using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Administrative permissions related to domain and its accounts.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainsAdministrativePermissions">https://www.icewarp.co.uk/api/#TDomainsAdministrativePermissions</see></para>
    /// </summary>
    public class TDomainsAdministrativePermissions : RpcBaseClass
    {
        /// <summary>
        /// options related to all accounts in this domain
        /// </summary>
        public TAdministrativePermissionsList AccountsRelatedPermissions { get; set; }
        /// <summary>
        /// options related to domain settings in this domain
        /// </summary>
        public TAdministrativePermissionsList DomainRelatedPermissions { get; set; }

        /// <inheritdoc />
        public TDomainsAdministrativePermissions()
        {
            AccountsRelatedPermissions = new TAdministrativePermissionsList();
            DomainRelatedPermissions = new TAdministrativePermissionsList();
        }

        /// <inheritdoc />
        public TDomainsAdministrativePermissions(XmlNode node)
        {
            if (node != null)
            {
                AccountsRelatedPermissions = new TAdministrativePermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => AccountsRelatedPermissions)));
                DomainRelatedPermissions = new TAdministrativePermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainRelatedPermissions)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(AccountsRelatedPermissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => AccountsRelatedPermissions)));
            element.AppendChild(DomainRelatedPermissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainRelatedPermissions)));

            return element;
        }
    }
}
