using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// TCP/IP Tunnel Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class TunnelToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable TCP/IP tunnel
        /// </summary>
        public bool? C_System_Tools_Tunnel_Enable { get; set; }

        /// <inheritdoc />
        public TunnelToolSettings()
        {
        }

        /// <inheritdoc />
        public TunnelToolSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
