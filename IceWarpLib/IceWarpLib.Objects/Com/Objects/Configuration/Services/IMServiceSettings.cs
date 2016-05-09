using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// IM Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class IMServiceSettings : ComBaseClass
    {
        /// <summary>
        /// IM service port - 5222
        /// </summary>
        public int? C_System_Services_IM_Port { get; set; }
        /// <summary>
        /// IM service SSL port - 5223
        /// </summary>
        public int? C_System_Services_IM_SSLPort { get; set; }
        /// <summary>
        /// IM service alternative port - 5269
        /// </summary>
        public int? C_System_Services_IM_AltPort { get; set; }
        /// <summary>
        /// Enable IM traffic logs
        /// </summary>
        public bool? C_System_Services_IM_Traffic { get; set; }
        /// <summary>
        /// List of Granted?Denied IPs
        /// </summary>
        public string C_System_Services_IM_IPList { get; set; }
        /// <summary>
        /// Service access mode
        /// </summary>
        public AccessGrant? C_System_Services_IM_AccessMode { get; set; }
        /// <summary>
        /// Startup
        /// <para>values=(0 - Automatic, 1 - Manual)</para>
        /// </summary>
        public Startup? C_System_Services_IM_Startup { get; set; } 
        /// <summary>
        /// Service thread cache - 40
        /// </summary>
        public int? C_System_Services_IM_ThreadCache { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_IM_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int? C_System_Services_IM_Bandwidth { get; set; }
        /// <summary>
        /// Monitor increased traffic
        /// </summary>
        public int? C_System_Services_IM_MonitorData { get; set; }
        /// <summary>
        /// Monitor number of increased connections
        /// </summary>
        public int? C_System_Services_IM_MonitorConn { get; set; }

        /// <inheritdoc />
        public IMServiceSettings()
        {
        }

        /// <inheritdoc />
        public IMServiceSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
