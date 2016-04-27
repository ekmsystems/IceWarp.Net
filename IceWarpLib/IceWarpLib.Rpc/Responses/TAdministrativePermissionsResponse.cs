using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// The permissions of an account
    /// <para><see href="https://www.icewarp.co.uk/api/#TAdministrativePermissions ">https://www.icewarp.co.uk/api/#TAdministrativePermissions </see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAccountAdministrativePermissions">https://www.icewarp.co.uk/api/#GetAccountAdministrativePermissions</seealso></para>
    /// </summary>
    public class TAdministrativePermissionsResponse : IceWarpResponse
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
        public TAdministrativePermissionsResponse(HttpRequestResult httpRequestResult) 
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                DomainsPermissions = new TDomainsPermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainsPermissions)));
                GlobalPermissions = new TAdministrativePermissionsList(node.GetSingleNode(ClassHelper.GetMemberName(() => GlobalPermissions)));
            }
        }
    }
}
