using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
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

        public TAdministrativePermissionsResponse(HttpRequestResult httpRequestResult) 
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                DomainsPermissions = new TDomainsPermissionsList(node.GetSingleNode("DomainsPermissions"));
                GlobalPermissions = new TAdministrativePermissionsList(node.GetSingleNode("GlobalPermissions"));
            }
        }
    }
}
