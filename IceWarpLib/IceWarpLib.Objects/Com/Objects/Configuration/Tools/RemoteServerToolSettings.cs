using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Remote Server Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class RemoteServerToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Remote server watchdog
        /// </summary>
        public bool? C_System_Tools_RemoteServer_Enable { get; set; }
        /// <summary>
        /// Server is down if unreachable for (Min)
        /// </summary>
        public int? C_System_Tools_RemoteServer_MoreThan { get; set; }
        /// <summary>
        /// Report Email address
        /// </summary>
        public string C_System_Tools_RemoteServer_Email { get; set; }
        /// <summary>
        /// Schedule Remote Server Watchdog Schedule
        /// </summary>
        public string C_System_Tools_RemoteServer_Schedule { get; set; }//TODO - figure out what gets returned - Schedule
        /// <summary>
        /// Notify when server is back online
        /// </summary>
        public bool? C_System_Tools_RemoteServer_NotifyAgain { get; set; }

        /// <inheritdoc />
        public RemoteServerToolSettings()
        {
        }

        /// <inheritdoc />
        public RemoteServerToolSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
