using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Atomic Clock Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class AtomicClockToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable Atomic clock sync
        /// </summary>
        public bool? C_System_Tools_AtomicClockSync_Enable { get; set; }

        /// <inheritdoc />
        public AtomicClockToolSettings()
        {
        }

        /// <inheritdoc />
        public AtomicClockToolSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
