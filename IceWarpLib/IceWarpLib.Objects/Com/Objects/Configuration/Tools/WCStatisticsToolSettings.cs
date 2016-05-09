using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// WC Statistics Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class WCStatisticsToolSettings : ComBaseClass
    {
        /// <summary>
        /// Switch to disable/enable collectiong of user statistics
        /// </summary>
        public bool? C_System_Tools_WCStatistics_Enabled { get; set; }
        /// <summary>
        /// Connection string to override default sqlite storage
        /// </summary>
        public string C_System_Tools_WCStatistics_ConnectionString { get; set; }
        /// <summary>
        /// Url to override default IceWarp collector server
        /// </summary>
        public string C_System_Tools_WCStatistics_ReportingUrl { get; set; }
        /// <summary>
        /// Switch to disable reporting to collector server
        /// </summary>
        public bool? C_System_Tools_WCStatistics_ReportingDisabled { get; set; }
        /// <summary>
        /// If Enabled, collected statistics are reported only in new day procedure
        /// </summary>
        public bool? C_System_Tools_WCStatistics_ReportingMidnight { get; set; }
        /// <summary>
        /// Write only variable - causes export of the collected statistic to the file given as parameter
        /// </summary>
        public string C_System_Tools_WCStatistics_ExportToXML { private get; set; }

        /// <inheritdoc />
        public WCStatisticsToolSettings()
        {
        }

        /// <inheritdoc />
        public WCStatisticsToolSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
