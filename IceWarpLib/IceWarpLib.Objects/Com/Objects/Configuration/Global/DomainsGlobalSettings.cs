using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Global
{
    /// <summary>
    /// Global Accounts Domains Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class DomainsGlobalSettings : ComBaseClass
    {
        /// <summary>
        /// Use Domain disk quota
        /// </summary>
        public bool? C_Accounts_Global_Domains_UseDiskQuota { get; set; }
        /// <summary>
        /// Use Domain user limits
        /// </summary>
        public bool? C_Accounts_Global_Domains_UseUserLimits { get; set; }
        /// <summary>
        /// Use Domain limits
        /// </summary>
        public bool? C_Accounts_Global_Domains_UseDomainLimits { get; set; }
        /// <summary>
        /// Use Domain expiration
        /// </summary>
        public bool? C_Accounts_Global_Domains_UseExpiration { get; set; }
        /// <summary>
        /// Override global limits
        /// </summary>
        public bool? C_Accounts_Global_Domains_OverrideGlobal { get; set; }
        /// <summary>
        /// Enable Domain literals
        /// </summary>
        public bool? C_Accounts_Global_Domains_Literals { get; set; }
        /// <summary>
        /// Enable DomainKeys support
        /// </summary>
        public bool? C_Accounts_Global_Domains_DomainKeys { get; set; }
        /// <summary>
        /// Use domain hostnames for outgoing msgs
        /// </summary>
        public bool? C_Accounts_Global_Domains_Hostname { get; set; }
        /// <summary>
        /// Use domain IP address for outgoing msgs
        /// </summary>
        public bool? C_Accounts_Global_Domains_IPAddress { get; set; }
        /// <summary>
        /// Use Welcome messages
        /// </summary>
        public bool? C_Accounts_Global_Domains_WelcomeMsgs { get; set; }
        /// <summary>
        /// Warn when mailbox size exceeds (%)
        /// </summary>
        public int? C_Accounts_Global_Domains_WarnMailboxUsage { get; set; }
        /// <summary>
        /// Repeat period of warning message user mailbox size quota exceeded in hours (0 means no repeat)
        /// </summary>
        public int? C_Accounts_Global_Domains_UserQuotaWrnMsgRepeat { get; set; }
        /// <summary>
        /// False for Disabled(Login) or True for Disabled(Login, Reeceive)
        /// </summary>
        public bool? C_Accounts_Global_Domains_UserAccountDisabledReceive { get; set; }
        /// <summary>
        /// Warn when domain size exceeds (%)
        /// </summary>
        public int? C_Accounts_Global_Domains_WarnDomainSize { get; set; }

        /// <inheritdoc />
        public DomainsGlobalSettings()
        {
        }

        /// <inheritdoc />
        public DomainsGlobalSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
