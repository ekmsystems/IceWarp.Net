namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    public class SystemBackupTool
    {
        /// <summary>
        /// Enable Auto backup
        /// </summary>
        public bool C_System_Tools_AutoBackup_Enable { get; set; }
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
        public string C_System_Tools_AutoBackup_Schedule { get; set; }
        /// <summary>
        /// Delete backup file after (Days)
        /// </summary>
        public int C_System_Tools_AutoBackup_DeleteAfter { get; set; }
        /// <summary>
        /// Include mail folder settings to backup
        /// </summary>
        public bool C_System_Tools_IncludeMailDir { get; set; }
        /// <summary>
        /// Do not include license to backup file
        /// </summary>
        public bool C_System_Tools_ExcludeLicense { get; set; }
        /// <summary>
        /// Backup emails
        /// </summary>
        public bool C_System_Tools_Backup_Emails { get; set; }
        /// <summary>
        /// Skip emails larger (MB)
        /// </summary>
        public int C_System_Tools_Backup_SkipLarger { get; set; }
        /// <summary>
        /// Skip emails older (Days)
        /// </summary>
        public int C_System_Tools_Backup_SkipOlder { get; set; }
        /// <summary>
        /// Additional directories to backup
        /// </summary>
        public string C_System_Tools_Backup_Dirs { get; set; }
        /// <summary>
        /// Backup logs
        /// </summary>
        public bool C_System_Tools_Backup_Logs { get; set; }
    }
}
