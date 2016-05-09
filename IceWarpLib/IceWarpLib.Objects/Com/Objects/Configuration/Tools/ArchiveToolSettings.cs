using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Mail Archive Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class ArchiveToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Auto archive
        /// </summary>
        public bool? C_System_Tools_AutoArchive_Enable { get; set; }
        /// <summary>
        /// Auto archive path
        /// </summary>
        public string C_System_Tools_AutoArchive_Path { get; set; } 
        /// <summary>
        /// Do not archive spam messages
        /// </summary>
        public bool? C_System_Tools_AutoArchive_DoNotSpam { get; set; }   
        /// <summary>
        /// Delete archive older than (Days)
        /// </summary>
        public int? C_System_Tools_AutoArchive_DeleteOlder { get; set; }    
        /// <summary>
        /// Archive Outgoing Option
        /// <para>values = (ammAll, ammInbox, ammAllRoot, ammInboxRoot, ammDeleted)</para>
        /// </summary>
        public ArchiveOption? C_System_Tools_AutoArchive_Outgoing { get; set; }    
        /// <summary>
        /// Backup archive
        /// </summary>
        public bool? C_System_Tools_AutoArchive_Backup_Active { get; set; }   
        /// <summary>
        /// Delete old archive backups
        /// </summary>
        public int? C_System_Tools_AutoArchive_Backup_DeleteOlder { get; set; }    
        /// <summary>
        /// Archive backup file
        /// </summary>
        public string C_System_Tools_AutoArchive_Backup_File { get; set; } 
        /// <summary>
        /// Password
        /// </summary>
        public string C_System_Tools_AutoArchive_Backup_Password { get; set; } 
        /// <summary>
        /// Archive directory trailer path
        /// </summary>
        public string C_System_Tools_AutoArchive_TrailerPath { get; set; } 
        /// <summary>
        /// Archive IMAP folder name
        /// </summary>
        public string C_System_Tools_AutoArchive_IMAPArchiveName { get; set; } 
        /// <summary>
        /// Enable integration of archive with IMAP
        /// </summary>
        public bool? C_System_Tools_AutoArchive_IMAPArchive { get; set; }   
        /// <summary>
        /// Archive Sent IMAP folder name
        /// </summary>
        public string C_System_Tools_AutoArchive_IMAPArchiveSent { get; set; } 
        /// <summary>
        /// Archive Inbox IMAP folder name
        /// </summary>
        public string C_System_Tools_AutoArchive_IMAPArchiveInbox { get; set; } 
        /// <summary>
        /// Archive mail for unknown users
        /// </summary>
        public bool? C_System_Tools_AutoArchive_UnknownUsers { get; set; }   
        /// <summary>
        /// Forward archived messages to
        /// </summary>
        public string C_System_Tools_AutoArchive_ForwardArchive { get; set; } 
        /// <summary>
        /// Optional group speciying users with access to archive
        /// </summary>
        public string C_System_Tools_AutoArchive_GroupAccess { get; set; } 
        /// <summary>
        /// Enable RSS archive
        /// </summary>
        public  bool? C_System_Tools_AutoArchive_RSS { get; set; }   

        /// <inheritdoc />
        public ArchiveToolSettings()
        {
        }

        /// <inheritdoc />
        public ArchiveToolSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
