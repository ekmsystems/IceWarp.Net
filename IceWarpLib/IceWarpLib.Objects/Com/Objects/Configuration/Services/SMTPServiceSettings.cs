using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// SMTP Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class SMTPServiceSettings : ComBaseClass
    {
        /// <summary>
        /// if set to false, sending to aliases of backup and distributed domains does not rewrite recipients domain with the domain where the alias points to
        /// </summary>
        public bool? C_System_Services_SMTP_Rewrite_Backup_Recipients { get; set; }
        /// <summary>
        /// enables limiting of number of outgoing connections to the same domain per minute
        /// </summary>
        public bool? C_System_Services_SMTP_MaxOutgoingLimitPerDomainEnabled { get; set; }
        /// <summary>
        /// for  C_System_Services_SMTP_MaxOutgoingLimitPerDomainEnabled
        /// </summary>
        public int? C_System_Services_SMTP_MaxOutgoingLimitPerDomainValue { get; set; }
        /// <summary>
        /// enables limiting of number of outgoing connections from the same domain per minute
        /// </summary>
        public bool? C_System_Services_SMTP_MaxSenderLimitPerDomainEnabled { get; set; }
        /// <summary>
        /// Value for C_System_Services_SMTP_MaxSenderLimitPerDomainEnabled
        /// </summary>
        public int? C_System_Services_SMTP_MaxSenderLimitPerDomainValue { get; set; }
        /// <summary>
        /// Experimental - Never set this to true
        /// </summary>
        public bool? C_System_Services_SMTP_SendingStopped { get; set; }
        /// <summary>
        /// When enabled,  user can receive messages even if his mailbox is full, but he can not send any message instead
        /// </summary>
        public bool? C_System_Services_SMTP_SoftQuota { get; set; }
        /// <summary>
        /// SMTP service port - 25
        /// </summary>
        public int? C_System_Services_SMTP_Port { get; set; }
        /// <summary>
        /// SMTP service SSL port - 465
        /// </summary>
        public int? C_System_Services_SMTP_SSLPort { get; set; }
        /// <summary>
        /// SMTP service alternative port  -366
        /// </summary>
        public int? C_System_Services_SMTP_AltPort { get; set; }
        /// <summary>
        /// Enable SMTP traffic logs
        /// </summary>
        public bool? C_System_Services_SMTP_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_SMTP_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant? C_System_Services_SMTP_AccessMode { get; set; }
        /// <summary>
        /// Startup
        /// </summary>
        public Startup? C_System_Services_SMTP_Startup { get; set; } 
        /// <summary>
        /// SMTP service Thread cache - 40
        /// </summary>
        public int? C_System_Services_SMTP_ThreadCache { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_SMTP_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_SMTP_MonitorConn { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_SMTP_MaxInConn { get; set; }
        /// <summary>
        /// Max number of Outgoing connections - 256
        /// </summary>
        public int? C_System_Services_SMTP_MaxOutConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s) 0
        /// </summary>
        public int? C_System_Services_SMTP_Bandwidth { get; set; }
        /// <summary>
        /// If set to true, presence of the session IP in Intrusion prevention list will be performed more often and not only at the beginning of the session
        /// </summary>
        public bool? C_System_Services_SMTP_Tarpitting_MoreRestrictive { get; set; }

        /// <inheritdoc />
        public SMTPServiceSettings()
        {
        }

        /// <inheritdoc />
        public SMTPServiceSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
