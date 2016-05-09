using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// POP3 Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class POP3ServiceSettings : ComBaseClass
    {
        /// <summary>
        /// POP3 service port - 110
        /// </summary>
        public int? C_System_Services_POP3_Port { get; set; }
        /// <summary>
        /// POP3 service SSL port - 995
        /// </summary>
        public int? C_System_Services_POP3_SSLPort { get; set; }
        /// <summary>
        /// Enable SMTP traffic logs
        /// </summary>
        public bool? C_System_Services_POP3_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_POP3_IPList { get; set; }
        /// <summary>
        /// Service access mode - Deny
        /// </summary>
        public AccessGrant? C_System_Services_POP3_Accessmode { get; set; }
        /// <summary>
        /// Startup
        /// </summary>
        public Startup? C_System_Services_POP3_Startup { get; set; } 
        /// <summary>
        /// POP3 service thread cache - 40
        /// </summary>
        public int? C_System_Services_POP3_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_POP3_MaxInConn { get; set; }
        /// <summary>
        /// Max number of Outgoing connections
        /// </summary>
        public int? C_System_Services_POP3_MaxOutConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kb/s)
        /// </summary>
        public int? C_System_Services_POP3_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_POP3_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_POP3_MonitorConn { get; set; }
        /// <summary>
        /// POP3 does not allow multiple login of one account
        /// </summary>
        public bool? C_System_POP3_Locking { get; set; }

        /// <inheritdoc />
        public POP3ServiceSettings()
        {
        }

        /// <inheritdoc />
        public POP3ServiceSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
