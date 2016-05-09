using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// IMAP Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class IMAPServiceSettings : ComBaseClass
    {
        /// <summary>
        /// IMAP service port - 143
        /// </summary>
        public int? C_System_Services_IMAP_Port { get; set; } 
        /// <summary>
        /// IMAP service SSL port - 993
        /// </summary>
        public int? C_System_Services_IMAP_SSLPort { get; set; } 
        /// <summary>
        /// IMAP Service - Enable IMAP traffic logs
        /// </summary>
        public bool? C_System_Services_IMAP_Traffic { get; set; }
        /// <summary>
        /// IMAP service thread cache - 40
        /// </summary>
        public int? C_System_Services_IMAP_ThreadCache { get; set; } 
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_IMAP_MaxInConn { get; set; } 
        /// <summary>
        /// Max number of Outgoing connections-  1
        /// </summary>
        public int? C_System_Services_IMAP_MaxOutConn { get; set; } 
        /// <summary>
        /// IMAP Service - Max transfer bandwidth (kB/s)
        /// </summary>
        public int? C_System_Services_IMAP_Bandwidth { get; set; } 
        /// <summary>
        /// IMAP Service - List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_IMAP_IPList { get; set; } 
        /// <summary>
        /// Service access mode - Deny
        /// </summary>
        public AccessGrant? C_System_Services_IMAP_Accessmode { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_IMAP_MonitorData { get; set; } 
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_IMAP_MonitorConn { get; set; } 
        /// <summary>
        /// Use IMAP flags encoded in mail filename
        /// </summary>
        public bool? C_System_Services_IMAP_FileNameFlags { get; set; }
        /// <summary>
        /// Integrate IMAP search with indexing service
        /// <para>values=(0 - No Integration, 1 - Windows Desktop Search</para>
        /// </summary>
        public IMAPIndexedSearch? C_System_Services_IMAP_IndexedSearch { get; set; }
        /// <summary>
        /// Do not search in mail body
        /// </summary>
        public bool? C_System_Services_IMAP_DisableBodySearch { get; set; }
        /// <summary>
        /// Integrate IMAP search with indexing service
        /// </summary>
        public int? C_System_Services_IMAP_RSSInterval { get; set; } 
        /// <summary>
        /// Copy/Move from Inbox to Spam indexes e-mail to Blacklist, Copy/Move from Spam to Inbox indexes e-mail to WhiteList
        /// </summary>
        public bool? C_System_Services_IMAP_CopyBWFunction { get; set; }
        /// <summary>
        /// (hours) Determines how often is IMAP going to sync contents of imapindex.dat with filesystem. When the time for next sync is evalueted, random number between 0 and this value is added to this value. The full item sync should be needed only if some files were added directly on filesystem.
        /// </summary>
        public int? C_System_Services_IMAP_FullSyncInterval { get; set; } 
        /// <summary>
        /// When IDLE is performed, information about all items are freed from memory and reloaded only after changes are detected or when idle is terminated
        /// </summary>
        public bool? C_System_Services_IMAP_FreeMemoryOnIdle { get; set; }
        /// <summary>
        /// Maximal size (in bytes) of cache for small files, (imapindex.dat, flags.dat...), Seto 0 to disable, do not enable on LB scenarios
        /// </summary>
        public string C_System_Services_SmallFilesCache_Size { get; set; } 
        /// <summary>
        /// Maximal size (in bytes) of file, which will be cached in cache for small files, (imapindex.dat, flags.dat...)
        /// </summary>
        public int? C_System_Services_SmallFilesCache_MaxFileSize { get; set; } 
        /// <summary>
        /// If set to true, cache write operations are not directly done on filesystem, but are procesed in background thread - temporarily switched off (i.e. this setting has no effect now)
        /// </summary>
        public bool? C_System_Services_SmallFilesCache_DelayWrite { get; set; }
        /// <summary>
        /// If connection string is set, IMAP service will use DB engine for caching contents of imapindex.dat and similar files and for locking directories. 
        /// <para>It has sense only in LB scenario. It requires mysql db for directorycache. It uses 2 redundant tables in directorycache db</para>
        /// </summary>
        public string C_System_Services_IMAP_DBCache_ConnectionString { get; set; } 

        /// <inheritdoc />
        public IMAPServiceSettings()
        {
        }

        /// <inheritdoc />
        public IMAPServiceSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
