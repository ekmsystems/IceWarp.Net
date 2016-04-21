namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    public class SystemMonitorTool
    {
        /// <summary>
        /// Enable System monitor
        /// </summary>
        public bool C_System_Tools_Monitor_Enable { get; set; }
        /// <summary>
        /// Disk monitor report address
        /// </summary>
        public string C_System_Tools_Monitor_ReportAddress { get; set; }
        /// <summary>
        /// Alert if free memory drops below (kB)
        /// </summary>
        public int C_System_Tools_Monitor_FreeMem { get; set; }
        /// <summary>
        /// Alert if free disk space drops below (MB)
        /// </summary>
        public int C_System_Tools_Monitor_DiskSize { get; set; }
        /// <summary>
        /// CPU utilization threshold (%)
        /// </summary>
        public int C_System_Tools_Monitor_CPUUsagePerc { get; set; }
        /// <summary>
        /// Alert if CPU usage exceeds threshold for (Min)
        /// </summary>
        public int C_System_Tools_Monitor_CPUUsagePeriod { get; set; }
    }
}
