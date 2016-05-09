using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Flags;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration
{
    /// <summary>
    /// System Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class SystemSettings : ComBaseClass
    {
        /// <summary>
        /// Disable transaction usage in directorycache processing
        /// </summary>
        public bool? C_System_Server_DirectoryCacheDontUseTransactions { get; set; }
        /// <summary>
        /// Directory Cache logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_System_Log_Services_DirectoryCache { get; set; }
        /// <summary>
        /// AD synchronization logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary)</para>
        /// </summary>
        public LoggingLevel? C_System_ADSyncLogType { get; set; }
        /// <summary>
        /// If AD synchronization search returns error, but still some data were returned, Synchronization performs no delete operation by default. Setting this to true enables delete operations for this cases.
        /// </summary>
        public bool? C_System_ADSyncIgnoreSearchError { get; set; }
        /// <summary>
        /// If set to value greater than 0, AD sync performs no delete if it should delete more accounts than this value
        /// </summary>
        public int? C_System_ADSyncMaxDeleteThreshold { get; set; }
        /// <summary>
        /// If set, AD sync will not fill in user's Card with information from AD server
        /// </summary>
        public bool? C_System_ADSyncDisableVCardSync { get; set; }
        /// <summary>
        /// Kerberos Authentication logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary)</para>
        /// </summary>
        public LoggingLevel? C_System_KerberosLogType { get; set; }
        /// <summary>
        /// Console Policy
        /// <para>values=(1 - Disable file manager, 2 - Disable DNS tool, 4 - Disable API console, 8 - Disable SQL manager)</para>
        /// </summary>
        public SystemConsolePolicyFlag? C_System_Console_Policy { get; set; }
        /// <summary>
        /// If enabled - ServerId (see Load Ballancing) will appear at the end of generated filenames and not at the beginning
        /// </summary>
        public bool? C_System_FileName_Ends_With_ServerId { get; set; }
        /// <summary>
        /// Restrict access to all services
        /// </summary>
        public bool? C_System_Services_Firewall { get; set; }
        /// <summary>
        /// IP addresses to bind services to
        /// </summary>
        public string C_System_Services_BindIPAddress { get; set; }
        /// <summary>
        /// MySQL default charset
        /// <para>Default charset for direct MySQL client library - older icewarps (version 5 and older) used to be set to latin1 for MySQL connection.</para>
        /// <para>On IceWarp 10 it uses utf8 by default.</para>
        /// <para>If your DB is in latin 1, in a fresh install you need to set this to latin1 or convert your DB to utf8</para>
        /// </summary>
        public string C_System_MySQLDefaultCharset { get; set; }
        /// <summary>
        /// Type of SQL logging
        /// </summary>
        public SqlLogging? C_System_SQLLogType { get; set; }
        /// <summary>
        /// Disable transaction usage in Useraccess processing
        /// </summary>
        public bool? C_System_Server_UserAccessDontUseTransactions { get; set; }
        /// <summary>
        /// Disables startserver services (Java, CommTouch, LDAP and others)
        /// </summary>
        public bool? C_System_Debug_DisableStartServerServices { get; set; }

        /// <inheritdoc />
        public SystemSettings()
        {
        }

        /// <inheritdoc />
        public SystemSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
