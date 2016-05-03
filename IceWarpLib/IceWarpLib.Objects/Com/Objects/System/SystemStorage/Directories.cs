namespace IceWarpLib.Objects.Com.Objects.System.SystemStorage
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class Directories : ComBaseClass
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
