using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemServices
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class GroupWareService : ComBaseClass
    {
        /// <summary>
        /// GW service port - 5229
        /// </summary>
        public int C_System_Services_GW_Port { get; set; }
        /// <summary>
        /// Enable GW traffic logs
        /// </summary>
        public bool C_System_Services_GW_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_GW_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant C_System_Services_GW_AccessMode { get; set; }
        /// <summary>
        /// GW service Thread cache - 40
        /// </summary>
        public int C_System_Services_GW_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int C_System_Services_GW_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int C_System_Services_GW_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int C_System_Services_GW_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int C_System_Services_GW_MonitorConn { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public bool C_System_Services_SyncML_AccessMode { get; set; }

        public string C_System_Services_SyncML_AccessGroup { get; set; }

    }
}
