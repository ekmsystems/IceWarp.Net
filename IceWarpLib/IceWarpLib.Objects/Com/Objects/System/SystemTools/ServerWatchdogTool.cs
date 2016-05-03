namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class ServerWatchdogTool : ComBaseClass
    {
        /// <summary>
        /// Enable Watchdog for SMTP
        /// </summary>
        public bool C_System_Tools_WatchDog_SMTP { get; set; }
        /// <summary>
        /// Enable Watchdog for POP3
        /// </summary>
        public bool C_System_Tools_WatchDog_POP3 { get; set; }
        /// <summary>
        /// Enable Watchdog for IM
        /// </summary>
        public bool C_System_Tools_WatchDog_IM { get; set; }
        /// <summary>
        /// Enable Watchdog for GW
        /// </summary>
        public bool C_System_Tools_Watchdog_GW { get; set; }
        /// <summary>
        /// Enable Watchdog for Control
        /// </summary>
        public bool C_System_Tools_Watchdog_Control { get; set; }
        /// <summary>
        /// Watchdog Interval
        /// </summary>
        public int C_System_Tools_Watchdog_Int { get; set; }

    }
}
