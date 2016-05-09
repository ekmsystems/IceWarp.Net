using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// Minger Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class MingerServiceSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Minger server
        /// </summary>
        public bool? C_System_Services_Minger_Enabled { get; set; }
        /// <summary>
        /// Minger Service -Basic Minger port (UDP)
        /// </summary>
        public int? C_System_Services_Minger_Port { get; set; }
        /// <summary>
        /// Minger Service -SSL port (TCP)
        /// </summary>
        public int? C_System_Services_Minger_SSLPort { get; set; }
        /// <summary>
        /// Minger Service -log level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_System_Services_Minger_Logging { get; set; } 

        /// <inheritdoc />
        public MingerServiceSettings()
        {
        }

        /// <inheritdoc />
        public MingerServiceSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
