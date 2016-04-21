namespace IceWarpLib.Objects.Com.Objects.System.SystemStorage
{
    public class Directories
    {
        /// <summary>
        /// Path to mail folder
        /// </summary>
        public string C_System_Storage_Dir_MailPath { get; set; }
        /// <summary>
        /// Path to temp folder
        /// </summary>
        public string C_System_Storage_Dir_TempPath { get; set; }
        /// <summary>
        /// Path to log folder
        /// </summary>
        public string C_System_Storage_Dir_LogPath { get; set; }
        /// <summary>
        /// Enables mailbox path alphabetical sorting
        /// </summary>
        public bool C_System_Storage_Mailbox_UseSorting { get; set; }
        /// <summary>
        /// Number of characters from alias to prefix
        /// </summary>
        public int C_System_Storage_Mailbox_PrefixLen { get; set; }
    }
}
