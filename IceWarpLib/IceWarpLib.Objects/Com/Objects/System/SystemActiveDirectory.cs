using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class SystemActiveDirectory : ComBaseClass
    {
        /// <summary>
        /// AD synchronization logging level
        /// </summary>
        public LoggingLevel C_System_ADSyncLogType { get; set; }
        /// <summary>
        /// If AD synchronization search returns error, but still some data returned, by default (false), synchronization does not perform any delete operation.
        /// Set to true, delete operations are enabled fro these cases.
        /// </summary>
        public bool C_System_ADSyncIgnoreSearchError { get; set; }
        /// <summary>
        /// If set to value greater than 0 (zero), AD synchronization does not perform any account delete, if the number should exceed this value.
        /// </summary>
        public int C_System_ADSyncMaxDeleteThreshold { get; set; }
        /// <summary>
        /// This variable disables personal data synchronization from AD, only accounts are then synchronized from AD.
        /// </summary>
        public int C_System_ADSyncDisableVCardSync { get; set; }

    }
}
