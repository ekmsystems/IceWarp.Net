using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemServices
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class SMTPService
    {
        /// <summary>
        /// SMTP service port - 25
        /// </summary>
        public int C_System_Services_SMTP_Port { get; set; }
        /// <summary>
        /// SMTP service SSL port - 465
        /// </summary>
        public int C_System_Services_SMTP_SSLPort { get; set; }
        /// <summary>
        /// SMTP service alternative port  -366
        /// </summary>
        public int C_System_Services_SMTP_AltPort { get; set; }
        /// <summary>
        /// Enable SMTP traffic logs
        /// </summary>
        public bool C_System_Services_SMTP_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_SMTP_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant C_System_Services_SMTP_AccessMode { get; set; }
        /// <summary>
        /// SMTP service Thread cache
        /// </summary>
        public int C_System_Services_SMTP_ThreadCache { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int C_System_Services_SMTP_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int C_System_Services_SMTP_MonitorConn { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int C_System_Services_SMTP_MaxInConn { get; set; }
        /// <summary>
        /// Max number of Outgoing connections - 256
        /// </summary>
        public int C_System_Services_SMTP_MaxOutConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s) 0
        /// </summary>
        public int C_System_Services_SMTP_Bandwidth { get; set; }
    }
}
