namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class Statistics : ComBaseClass
    {
        /// <summary>
        /// Unix time of start
        /// </summary>
        public int C_System_Tools_Migration_Stat_Start { get; set; }
        /// <summary>
        /// Total number of migrated mailboxes
        /// </summary>
        public int C_System_Tools_Migration_Stat_TotalUsers { get; set; }
        /// <summary>
        /// Number of migrated mailboxes
        /// </summary>
        public int C_System_Tools_Migration_Stat_Users { get; set; }
        /// <summary>
        /// Number of migrated aliases
        /// </summary>
        public int C_System_Tools_Migration_Stat_Aliases { get; set; }
        /// <summary>
        /// Number of messages migrated
        /// </summary>
        public int C_System_Tools_Migration_Stat_Messages { get; set; }
        /// <summary>
        /// Unix time of last migrated mailbox
        /// </summary>
        public int C_System_Tools_Migration_Stat_Last { get; set; }
        /// <summary>
        /// Number of migration errors
        /// </summary>
        public int C_System_Tools_Migration_Stat_Errors { get; set; }
    }
}
