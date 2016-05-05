using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class StaticRoute : Account
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string R_Name {get; set; }
        /// <summary>
        /// Action
        /// </summary>
        public StaticRouteAction R_Activity {get; set; }
        /// <summary>
        /// Forward
        /// </summary>
        public bool R_ExternalDomain {get; set; }
        /// <summary>
        /// Value
        /// </summary>
        public string R_ActivityValue {get; set; }
        /// <summary>
        /// Forward to address - Service access??
        /// </summary>
        public string R_SaveTo {get; set; }
        /// <summary>
        /// Filter
        /// </summary>
        public ExternalFilter R_ExternalFilter {get; set; }
        /// <summary>
        /// Filter file
        /// </summary>
        public string R_FilterFile {get; set; }
        /// <summary>
        /// External filter file
        /// </summary>
        public string R_ExternalFilterFile {get; set; }
        /// <summary>
        /// External filter type
        /// </summary>
        public ExecutableType R_ExternalFilterType {get; set; }
    }
}
