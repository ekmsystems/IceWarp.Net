using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System
{
    public class SystemInternetConnection
    {
        /// <summary>
        /// Connection mode
        /// </summary>
        public InternetConnectionMode C_System_Conn_Type { get; set; }
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
        public int C_System_Conn_UpHangUpAfter { get; set; }
        /// <summary>
        /// Connect if msg waits for more than (Min)
        /// </summary>
        public int C_System_Conn_UpOlderthan { get; set; }
        /// <summary>
        /// Connect if number of msgs exceeds
        /// </summary>
        public int C_System_Conn_DialOnDemandExceed { get; set; }
        /// <summary>
        /// Connect if message with this header
        /// </summary>
        public bool C_System_Conn_DialOnDemandHeader { get; set; }
        /// <summary>
        /// Schedule Connection schedule
        /// </summary>
        public string C_System_Conn_Schedule { get; set; }//TODO - figure out exact type for this property
        /// <summary>
        /// Schedule Global schedule
        /// </summary>
        public string C_System_Conn_GlobalSchedule { get; set; }//TODO - figure out exact type for this property

    }
}
