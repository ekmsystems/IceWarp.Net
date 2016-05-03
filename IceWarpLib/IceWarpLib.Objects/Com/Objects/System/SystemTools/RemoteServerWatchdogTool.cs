namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class RemoteServerWatchdogTool
    {
        /// <summary>
        /// Enable Remote server watchdog
        /// </summary>
        public bool C_System_Tools_RemoteServer_Enable { get; set; }
        /// <summary>
        /// Server is down if unreachable for (Min)
        /// </summary>
        public int C_System_Tools_RemoteServer_MoreThan { get; set; }
        /// <summary>
        /// Report Email address
        /// </summary>
        public string C_System_Tools_RemoteServer_Email { get; set; }
        /// <summary>
        /// Schedule Remote Server Watchdog Schedule
        /// </summary>
        public string C_System_Tools_RemoteServer_Schedule { get; set; }
        /// <summary>
        /// Notify when server is back online
        /// </summary>
        public bool C_System_Tools_RemoteServer_NotifyAgain { get; set; }
    }
}
