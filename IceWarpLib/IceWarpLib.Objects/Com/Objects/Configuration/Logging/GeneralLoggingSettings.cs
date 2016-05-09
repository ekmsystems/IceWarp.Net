using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Logging
{
    /// <summary>
    /// General Logging Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class GeneralLoggingSettings : ComBaseClass
    {
        /// <summary>
        /// Append logs to files
        /// </summary>
        public bool? C_System_Logging_General_AppendFiles { get; set; }
        /// <summary>
        /// Delete logs after (Days) 7
        /// </summary>
        public int? C_System_Logging_General_DeleteOlder { get; set; }
        /// <summary>
        /// Enable deleted logs archiving
        /// </summary>
        public bool? C_System_Logging_General_Archive { get; set; }
        /// <summary>
        /// Deleted log archive target
        /// </summary>
        public string C_System_Logging_General_ArchiveTo { get; set; }
        /// <summary>
        /// Logging cache (Bytes)
        /// </summary>
        public int? C_System_Logging_General_LogCache { get; set; }
        /// <summary>
        /// Size of the log file (kBytes)
        /// </summary>
        public int? C_System_Logging_General_LogRotation { get; set; }
        /// <summary>
        /// Send logs to system log function
        /// </summary>
        public bool? C_System_Logging_General_SystemLogFunction { get; set; }
        /// <summary>
        /// Send logs to server
        /// </summary>
        public bool? C_System_Logging_Syslog_Active { get; set; }
        /// <summary>
        /// Syslog server name
        /// </summary>
        public string C_System_Logging_Syslog_Server { get; set; }
        /// <summary>
        /// Enable ODBC logging
        /// </summary>
        public bool? C_System_Logging_General_EnableODBCLog { get; set; }
        /// <summary>
        /// ODBC logging connection
        /// </summary>
        public string C_System_Logging_General_ODBCLogConn { get; set; }
        /// <summary>
        /// Log time format
        /// </summary>
        public LogTimeFormat? C_System_Logging_General_LogTimeFormat { get; set; }
        /// <summary>
        /// Enables experimental file logging mode - everything is sent to control service using pipe connection, from background thread
        /// </summary>
        public bool? C_System_Logging_General_ExperimentalFastLogging { get; set; }
        /// <summary>
        /// Enables more detailed logging of system exceptions, if enabled, whole stacktrace is logged
        /// </summary>
        public bool? C_System_Logging_General_EnableStackTrace { get; set; }
        /// <summary>
        /// Thread variable - will be used in maintenance logs as "WHO"
        /// </summary>
        public string C_System_Logging_Maintenance_Identity { get; set; }
        /// <summary>
        /// Disable session history
        /// </summary>
        public bool? C_System_Sessions_DisableHistory { get; set; }
        /// <summary>
        /// Debug performance - actions exceeding time in seconds
        /// </summary>
        public int? C_System_Log_Performance { get; set; }
        /// <summary>
        /// Debug performance - level of importance  0 - basic, 10 - brutal
        /// </summary>
        public int? C_System_Log_Performance_Level { get; set; }
        /// <summary>
        /// Maximum single log size in bytes - 0 means unlimited
        /// </summary>
        public int? C_System_Log_MaxLogSize { get; set; }

        /// <inheritdoc />
        public GeneralLoggingSettings()
        {
        }

        /// <inheritdoc />
        public GeneralLoggingSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
