using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// Groupware Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class GroupWareServiceSettings : ComBaseClass
    {
        /// <summary>
        /// GW service port - 5229
        /// </summary>
        public int? C_System_Services_GW_Port { get; set; }
        /// <summary>
        /// Enable GW traffic logs
        /// </summary>
        public bool? C_System_Services_GW_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_GW_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant? C_System_Services_GW_AccessMode { get; set; }
        /// <summary>
        /// Startup 
        /// <para>values=(0 - Automatic, 1 - Manual)</para>
        /// </summary>
        public Startup? C_System_Services_GW_Startup { get; set; }
        /// <summary>
        /// GW service Thread cache - 40
        /// </summary>
        public int? C_System_Services_GW_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_GW_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int? C_System_Services_GW_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_GW_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_GW_MonitorConn { get; set; }

        /// <inheritdoc />
        public GroupWareServiceSettings()
        {
        }

        /// <inheritdoc />
        public GroupWareServiceSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
