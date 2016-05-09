using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Backup Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class BackupToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Auto backup
        /// </summary>
        public bool? C_System_Tools_AutoBackup_Enable { get; set; }
        /// <summary>
        /// Path to backup file
        /// </summary>
        public string C_System_Tools_AutoBackup_BackupTo { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string C_System_Tools_AutoBackup_Password { get; set; }
        /// <summary>
        /// Schedule Auto backup Schedule
        /// </summary>
        public string C_System_Tools_AutoBackup_Schedule { get; set; }//TODO - figure out what gets returned - Schedule
        /// <summary>
        /// Delete backup file after (Days)
        /// </summary>
        public int? C_System_Tools_AutoBackup_DeleteAfter { get; set; }
        /// <summary>
        /// Include mail folder settings to backup
        /// </summary>
        public bool? C_System_Tools_IncludeMailDir { get; set; }
        /// <summary>
        /// Do not include license to backup file
        /// </summary>
        public bool? C_System_Tools_ExcludeLicense { get; set; }
        /// <summary>
        /// Backup emails
        /// </summary>
        public bool? C_System_Tools_Backup_Emails { get; set; }
        /// <summary>
        /// Skip emails larger (MB)
        /// </summary>
        public int? C_System_Tools_Backup_SkipLarger { get; set; }
        /// <summary>
        /// Skip emails older (Days)
        /// </summary>
        public int? C_System_Tools_Backup_SkipOlder { get; set; }
        /// <summary>
        /// Additional directories to backup
        /// </summary>
        public string C_System_Tools_Backup_Dirs { get; set; }
        /// <summary>
        /// Backup logs
        /// </summary>
        public bool? C_System_Tools_Backup_Logs { get; set; }
        /// <summary>
        /// Backup groupware attachments
        /// </summary>
        public bool? C_System_Tools_Backup_GWAttach { get; set; }
        /// <summary>
        /// Backup account database
        /// </summary>
        public bool? C_System_Tools_Backup_DB_AccountsEnabled { get; set; }
        /// <summary>
        /// Accounts database backup target DSN
        /// </summary>
        public string C_System_Tools_Backup_DB_Accounts { get; set; }
        /// <summary>
        /// Backup Anti-Spam database
        /// </summary>
        public bool? C_System_Tools_Backup_DB_ASEnabled { get; set; }
        /// <summary>
        /// Anti-Spam database backup target DSN
        /// </summary>
        public string C_System_Tools_Backup_DB_AS { get; set; }
        /// <summary>
        /// Backup groupware database
        /// </summary>
        public bool? C_System_Tools_Backup_DB_GWEnabled { get; set; }
        /// <summary>
        /// Groupware database backup target DSN
        /// </summary>
        public string C_System_Tools_Backup_DB_GW { get; set; }
        /// <summary>
        /// Backup directory cache database
        /// </summary>
        public bool? C_System_Tools_Backup_DB_DirectoryCacheEnabled { get; set; }
        /// <summary>
        /// Directory cache database backup target DSN
        /// </summary>
        public string C_System_Tools_Backup_DB_DirectoryCache { get; set; }

        /// <inheritdoc />
        public BackupToolSettings()
        {
        }

        /// <inheritdoc />
        public BackupToolSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
