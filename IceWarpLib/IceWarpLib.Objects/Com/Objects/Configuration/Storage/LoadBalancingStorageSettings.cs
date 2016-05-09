using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Storage
{
    /// <summary>
    /// Load Balancing Storage Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class LoadBalancingStorageSettings : ComBaseClass
    {
        /// <summary>
        /// Server ID
        /// </summary>
        public string C_System_Storage_LB_ServerID { get; set; }
        /// <summary>
        /// Periodically check if settings have been changed and auto-reloaded
        /// </summary>
        public bool? C_System_Storage_LB_AutoCheckConfig { get; set; }

        /// <inheritdoc />
        public LoadBalancingStorageSettings()
        {
        }

        /// <inheritdoc />
        public LoadBalancingStorageSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
