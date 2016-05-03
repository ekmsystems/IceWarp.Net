using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemLogging
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class Services : ComBaseClass
    {
        /// <summary>
        /// SMTP service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_SMTP { get; set; }
        /// <summary>
        /// POP3 service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_POP3 { get; set; }
        /// <summary>
        /// IMAP service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_IMAP { get; set; }
        /// <summary>
        /// IM service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_IM { get; set; }
        /// <summary>
        /// GW service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_GW { get; set; }
        /// <summary>
        /// Control service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_Control { get; set; }
        /// <summary>
        /// FTP service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_FTP { get; set; }
        /// <summary>
        /// LDAP service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_LDAP { get; set; }
        /// <summary>
        /// AV logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_AV { get; set; }
        /// <summary>
        /// AS logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_AS { get; set; }
        /// <summary>
        /// SIP logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_SIP { get; set; }
        /// <summary>
        /// SMS service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_SMS { get; set; }
        /// <summary>
        /// SyncML service logging level
        /// </summary>
        public LoggingLevel C_System_Log_Services_SyncMLPush { get; set; }
        /// <summary>
        /// Debug logging - internal usage only
        /// </summary>
        public bool C_System_Log_MailQueue { get; set;}

    }
}
