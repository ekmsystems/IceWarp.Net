using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// This encapsulates permisions which can be defined FOR certain entity.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAdministrativePermissions">https://www.icewarp.co.uk/api/#TAdministrativePermissions</see></para>
    /// </summary>
    public class TAdministrativePermissions : RpcBaseClass
    {
        /// <summary>
        /// permissions defined on domain level
        /// </summary>
        public TDomainsPermissionsList DomainsPermissions { get; set; }
        /// <summary>
        /// permissions defined on global level
        /// </summary>
        public TAdministrativePermissionsList GlobalPermissions { get; set; }

        /// <inheritdoc />
        public TAdministrativePermissions()
        {
            DomainsPermissions = new TDomainsPermissionsList();
            GlobalPermissions = new TAdministrativePermissionsList();
        }

        /// <inheritdoc />
        public TAdministrativePermissions(XmlNode node)
        {
            if (node != null)
            {
                DomainsPermissions = new TDomainsPermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainsPermissions)));
                GlobalPermissions = new TAdministrativePermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => GlobalPermissions)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(DomainsPermissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DomainsPermissions)));
            element.AppendChild(GlobalPermissions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => GlobalPermissions)));

            return element;
        }
    }
}
