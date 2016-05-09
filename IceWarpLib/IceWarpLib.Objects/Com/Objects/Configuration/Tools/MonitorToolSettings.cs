using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Monitor Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class MonitorToolSettings : ComBaseClass
    {
        /// <summary>
        /// Enable System monitor
        /// </summary>
        public bool? C_System_Tools_Monitor_Enable { get; set; }
        /// <summary>
        /// Disk monitor report address
        /// </summary>
        public string C_System_Tools_Monitor_ReportAddress { get; set; }
        /// <summary>
        /// Alert if free memory drops below (kB)
        /// </summary>
        public int? C_System_Tools_Monitor_FreeMem { get; set; }
        /// <summary>
        /// Alert if free disk space drops below (MB)
        /// </summary>
        public int? C_System_Tools_Monitor_DiskSize { get; set; }
        /// <summary>
        /// CPU utilization threshold (%)
        /// </summary>
        public int? C_System_Tools_Monitor_CPUUsagePerc { get; set; }
        /// <summary>
        /// Alert if CPU usage exceeds threshold for (Min)
        /// </summary>
        public int? C_System_Tools_Monitor_CPUUsagePeriod { get; set; }
        /// <summary>
        /// Alert if Maximal waiting time on web threadpools in last 5 minutes exceeds threshold (Sec)
        /// </summary>
        public int? C_System_Tools_Monitor_WebThreadPoolThreshold { get; set; }

        /// <inheritdoc />
        public MonitorToolSettings()
        {
        }

        /// <inheritdoc />
        public MonitorToolSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
