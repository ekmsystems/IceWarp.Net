using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemServices
{
    public class FTPService
    {
        /// <summary>
        /// FTP service port - 21
        /// </summary>
        public int C_System_Services_FTP_Port { get; set; }
        /// <summary>
        /// FTP service SSL port - 990
        /// </summary>
        public int C_System_Services_FTP_SSLPort { get; set; }
        /// <summary>
        /// Enable FTP traffic logs
        /// </summary>
        public bool C_System_Services_FTP_Traffic { get; set; }
        /// <summary>
        /// List of Granted/Denied IPs
        /// </summary>
        public string C_System_Services_FTP_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant C_System_Services_FTP_AccessMode { get; set; }
        /// <summary>
        /// Service thread cache - 40
        /// </summary>
        public int C_System_Services_FTP_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int C_System_Services_FTP_MaxInConn { get; set; }
        /// <summary>
        /// Max number of Outgoing connections - 256
        /// </summary>
        public int C_System_Services_FTP_MaxOutConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int C_System_Services_FTP_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int C_System_Services_FTP_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int C_System_Services_FTP_MonitorConn { get; set; }

    }
}
