using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemServices
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class WebControlService : ComBaseClass
    {
        /// <summary>
        /// Control service port - 32000
        /// </summary>
        public int C_System_Services_Control_Port { get; set; }
        /// <summary>
        /// Control service SSL port - 32001
        /// </summary>
        public int C_System_Services_Control_SSLPort { get; set; }
        /// <summary>
        /// Enable Control traffic logs
        /// </summary>
        public bool C_System_Services_Control_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_Control_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant C_System_Services_Control_AccessMode { get; set; }
        /// <summary>
        /// Control service Thread cache - 40
        /// </summary>
        public int C_System_Services_Control_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int C_System_Services_Control_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int C_System_Services_Control_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int C_System_Services_Control_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int C_System_Services_Control_MonitorConn { get; set; }

    }
}
