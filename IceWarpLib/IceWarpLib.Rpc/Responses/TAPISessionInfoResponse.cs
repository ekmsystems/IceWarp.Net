using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Information about current session: Email,Domain, AdminType
    /// </summary>
    public class TAPISessionInfoResponse : IceWarpResponse
    {
        /// <summary>
        /// Account username or email address - depends on server login policy
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Account domain name
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// Account administration level. See <see cref="TAdminType"/> for more information.
        /// </summary>
        public TAdminType? AdminType { get; set; }
        
        public TAPISessionInfoResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                Email = Extensions.GetNodeInnerText(node.GetSingleNode("Email"));
                Domain = Extensions.GetNodeInnerText(node.GetSingleNode("Domain"));
                AdminType = (TAdminType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("AdminType"));
            }
        }
    }
}
