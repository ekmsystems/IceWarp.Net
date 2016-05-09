using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration
{
    /// <summary>
    /// Internet Connection Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class InternetConnectionSettings : ComBaseClass
    {
        /// <summary>
        /// Connection mode
        /// </summary>
        public InternetConnectionMode? C_System_Conn_Type { get; set; }
        /// <summary>
        /// Connection name
        /// </summary>
        public string C_System_Conn_UpName { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string C_System_Conn_UpUsername { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string C_System_Conn_UpPassword { get; set; }
        /// <summary>
        /// Hang up after (sec)
        /// </summary>
        public int? C_System_Conn_UpHangUpAfter { get; set; }
        /// <summary>
        /// Connect if msg waits for more than (Min)
        /// </summary>
        public int? C_System_Conn_UpOlderthan { get; set; }
        /// <summary>
        /// Connect if number of msgs exceeds
        /// </summary>
        public int? C_System_Conn_DialOnDemandExceed { get; set; }
        /// <summary>
        /// Connect if message with this header
        /// </summary>
        public bool? C_System_Conn_DialOnDemandHeader { get; set; }
        /// <summary>
        /// Connection schedule
        /// </summary>
        public string C_System_Conn_Schedule { get; set; }//TODO - figure out what gets returned - Schedule
        /// <summary>
        /// Global schedule
        /// </summary>
        public string C_System_Conn_GlobalSchedule { get; set; }//TODO - figure out what gets returned - Schedule
        /// <summary>
        /// Proxy for downloading files via HTTP
        /// </summary>
        public string C_System_Conn_Proxy { get; set; }

        /// <inheritdoc />
        public InternetConnectionSettings()
        {
        }

        /// <inheritdoc />
        public InternetConnectionSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
