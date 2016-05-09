using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// Proxy API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class ProxySettings : ComBaseClass
    {
        /// <summary>
        /// Enable Socks server
        /// </summary>
        public bool? C_System_Services_Socks_Enabled { get; set; }
        /// <summary>
        /// Socks port
        /// </summary>
        public int? C_System_Services_Socks_Port { get; set; }
        /// <summary>
        /// Maximum number of incoming connections
        /// </summary>
        public int? C_System_Services_Socks_MaxInConn { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_Socks_IPList { get; set; }
        /// <summary>
        /// Access type
        /// <para>values=(0 - deny, 1 - grant)</para>
        /// </summary>
        public AccessGrant? C_System_Services_Socks_IPGrant { get; set; }

        /// <inheritdoc />
        public ProxySettings()
        {
        }

        /// <inheritdoc />
        public ProxySettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
