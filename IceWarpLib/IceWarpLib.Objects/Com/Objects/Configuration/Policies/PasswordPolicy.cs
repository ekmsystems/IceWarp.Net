using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Policies
{
    /// <summary>
    /// Password Policy Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class PasswordPolicy : ComBaseClass
    {
        /// <summary>
        /// Enable Password policy
        /// </summary>
        public bool? C_Accounts_Policies_Pass_Enable { get; set; }
        /// <summary>
        /// Min password length
        /// </summary>
        public int? C_Accounts_Policies_Pass_MinLength { get; set; }
        /// <summary>
        /// Number of numeric chars in password
        /// </summary>
        public int? C_Accounts_Policies_Pass_Digits { get; set; }
        /// <summary>
        /// Number of non alphanumeric characters
        /// </summary>
        public int? C_Accounts_Policies_Pass_NonAlphaNum { get; set; }
        /// <summary>
        /// Check password against username/alias
        /// </summary>
        public bool? C_Accounts_Policies_Pass_UserAlias { get; set; }
        /// <summary>
        /// Enable password expiration
        /// </summary>
        public bool? C_Accounts_Policies_Pass_Expiration { get; set; }
        /// <summary>
        /// Expire after (Days)
        /// </summary>
        public int? C_Accounts_Policies_Pass_ExpireAfter { get; set; }
        /// <summary>
        /// Enable Notification of expiration
        /// </summary>
        public bool? C_Accounts_Policies_Pass_Notification { get; set; }
        /// <summary>
        /// Notify before (Days)
        /// </summary>
        public int? C_Accounts_Policies_Pass_NotifyBefore { get; set; }
        /// <summary>
        /// Passwords cannot be read or exported
        /// </summary>
        public bool? C_Accounts_Policies_Pass_DenyExport { get; set; }
        /// <summary>
        /// Allow Admin's password to be exported
        /// </summary>
        public bool? C_Accounts_Policies_Pass_AllowAdminPass { get; set; }
        /// <summary>
        /// Password database encryption
        /// </summary>
        public bool? C_Accounts_Policies_Pass_Encrypt { get; set; }
        /// <summary>
        /// Number of alpha characters
        /// </summary>
        public int? C_Accounts_Policies_Pass_Alpha { get; set; }
        /// <summary>
        /// Number of uppercase alpha characters
        /// </summary>
        public int? C_Accounts_Policies_Pass_UpperAlpha { get; set; }
        /// <summary>
        /// Allowed authentication SASL schemes
        /// </summary>
        public string C_Accounts_Policies_Auth_Schemes { get; set; }
        /// <summary>
        /// Make authenticated user the actual sender
        /// </summary>
        public bool? C_Accounts_Policies_Auth_ToMailFrom { get; set; }
        /// <summary>
        /// Disable plain authentication in all services
        /// </summary>
        public bool? C_Accounts_Policies_Auth_DisablePlain { get; set; }
        /// <summary>
        /// If enabled, IceWarp will not locally cache passwords of accounts authenticated externally (LDAP, or dll authentication). This will cause malfunction af all challenga based authentications
        /// </summary>
        public bool? C_Accounts_Policies_Auth_DontCacheExternalPasswords { get; set; }
        /// <summary>
        /// If synchronization library is not set on specific place ,this library will be used instead
        /// </summary>
        public string C_Accounts_Policies_Auth_DefaultExternalSyncLibrary { get; set; }

        /// <inheritdoc />
        public PasswordPolicy()
        {
        }

        /// <inheritdoc />
        public PasswordPolicy(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
