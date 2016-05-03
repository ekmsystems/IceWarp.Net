using System;
using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemLogging
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class General : ComBaseClass
    {
        /// <summary>
        /// Append logs to files
        /// </summary>
        public bool C_System_Logging_General_AppendFiles { get; set; }
        /// <summary>
        /// Delete logs after (Days) 7
        /// </summary>
        public int C_System_Logging_General_DeleteOlder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool C_System_Logging_General_Archive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string C_System_Logging_General_ArchiveTo { get; set; }
        /// <summary>
        /// Logging cache (B)
        /// </summary>
        public int C_System_Logging_General_LogCache { get; set; }
        /// <summary>
        /// Size of the log file (kB)
        /// </summary>
        public int C_System_Logging_General_LogRotation { get; set; }
        /// <summary>
        /// Send logs to system log function
        /// </summary>
        public bool C_System_Logging_General_SystemLogFunction { get; set; }
        /// <summary>
        /// Send logs to server
        /// </summary>
        public bool C_System_Logging_Syslog_Active { get; set; }
        /// <summary>
        /// Syslog server name
        /// </summary>
        public string C_System_Logging_Syslog_Server { get; set; }
        /// <summary>
        /// Enable ODBC logging
        /// </summary>
        public bool C_System_Logging_General_EnableODBCLog { get; set; }
        /// <summary>
        /// ODBC logging connection
        /// </summary>
        public string C_System_Logging_General_ODBCLogConn { get; set; }
        /// <summary>
        /// Log time format
        /// </summary>
        public LogTimeFormat C_System_Logging_General_LogTimeFormat { get; set; }
        /// <summary>
        /// Disable session history
        /// </summary>
        public Boolean C_System_Sessions_DisableHistory { get; set; }

    }
}
