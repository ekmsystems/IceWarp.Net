using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Logging
{
    /// <summary>
    /// Service Logging Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class Services : ComBaseClass
    {
        /// <summary>
        /// SMTP service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_SMTP { get; set; }
        /// <summary>
        /// POP3 service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_POP3 { get; set; }
        /// <summary>
        /// IMAP service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_IMAP { get; set; }
        /// <summary>
        /// IM service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_IM { get; set; }
        /// <summary>
        /// GW service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_GW { get; set; }
        /// <summary>
        /// Control service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_Control { get; set; }
        /// <summary>
        /// FTP service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_FTP { get; set; }
        /// <summary>
        /// LDAP service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_LDAP { get; set; }
        /// <summary>
        /// AV logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_AV { get; set; }
        /// <summary>
        /// AS logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_AS { get; set; }
        /// <summary>
        /// SIP logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_SIP { get; set; }
        /// <summary>
        /// SMS service logging level
        /// </summary>
        public LoggingLevel? C_System_Log_Services_SMS { get; set; }

        /// <inheritdoc />
        public Services()
        {
        }

        /// <inheritdoc />
        public Services(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
