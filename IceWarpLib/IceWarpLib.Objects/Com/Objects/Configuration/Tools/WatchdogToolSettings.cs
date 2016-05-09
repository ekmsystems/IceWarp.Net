using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Watchdog Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class WatchdogToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Watchdog for SMTP
        /// </summary>
        public bool? C_System_Tools_WatchDog_SMTP { get; set; }
        /// <summary>
        /// Enable Watchdog for POP3
        /// </summary>
        public bool? C_System_Tools_WatchDog_POP3 { get; set; }
        /// <summary>
        /// Enable Watchdog for IM
        /// </summary>
        public bool? C_System_Tools_WatchDog_IM { get; set; }
        /// <summary>
        /// Enable Watchdog for GW
        /// </summary>
        public bool? C_System_Tools_Watchdog_GW { get; set; }
        /// <summary>
        /// Enable Watchdog for Control
        /// </summary>
        public bool? C_System_Tools_Watchdog_Control { get; set; }
        /// <summary>
        /// Watchdog Interval
        /// </summary>
        public int? C_System_Tools_Watchdog_Int { get; set; }
        /// <summary>
        /// Should Watchdog connect on Service Port
        /// </summary>
        public bool? C_System_Tools_Watchdog_Check_Protocols { get; set; }
        /// <summary>
        /// Semicolon separated list of IP's on which will be checked protocols, all must success, not applicable on services with specific IP binding
        /// </summary>
        public string C_System_Tools_Watchdog_Check_IPList { get; set; }

        /// <inheritdoc />
        public WatchdogToolSettings()
        {
        }

        /// <inheritdoc />
        public WatchdogToolSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
