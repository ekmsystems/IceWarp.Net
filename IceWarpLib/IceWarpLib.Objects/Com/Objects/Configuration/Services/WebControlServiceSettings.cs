using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// Control Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class WebControlServiceSettings : ComBaseClass
    {
        /// <summary>
        /// Control service port - 32000
        /// </summary>
        public int? C_System_Services_Control_Port { get; set; }
        /// <summary>
        /// Control service SSL port - 32001
        /// </summary>
        public int? C_System_Services_Control_SSLPort { get; set; }
        /// <summary>
        /// Enable Control traffic logs
        /// </summary>
        public bool? C_System_Services_Control_Traffic { get; set; }
        /// <summary>
        /// List of Denied/Granted IPs
        /// </summary>
        public string C_System_Services_Control_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant? C_System_Services_Control_AccessMode { get; set; }
        /// <summary>
        /// Startup
        /// <para>values=(0 - Automatic, 1 - Manual)</para>
        /// </summary>
        public Startup? C_System_Services_Control_Startup { get; set; } 
        /// <summary>
        /// Control service Thread cache - 40
        /// </summary>
        public int? C_System_Services_Control_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_Control_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int? C_System_Services_Control_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_Control_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_Control_MonitorConn { get; set; }

        /// <inheritdoc />
        public WebControlServiceSettings()
        {
        }

        /// <inheritdoc />
        public WebControlServiceSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
