namespace IceWarpLib.Objects.Com.Objects.Policies
{
    public class PasswordPolicy
    {
        /// <summary>
        /// Enable Password policy
        /// </summary>
        public bool C_Accounts_Policies_Pass_Enable { get; set; }
        /// <summary>
        /// Check password against username/alias
        /// </summary>
        public bool C_Accounts_Policies_Pass_UserAlias { get; set; }
        /// <summary>
        /// Password database encryption
        /// </summary>
        public bool C_Accounts_Policies_Pass_Encrypt { get; set; }
        /// <summary>
        /// Min password length
        /// </summary>
        public int C_Accounts_Policies_Pass_MinLength { get; set; }
        /// <summary>
        /// Number of numeric chars in password
        /// </summary>
        public int C_Accounts_Policies_Pass_Digits { get; set; }
        /// <summary>
        /// Number of non alphanumeric characters
        /// </summary>
        public int C_Accounts_Policies_Pass_NonAlphaNum { get; set; }
        /// <summary>
        /// Number of alpha characters
        /// </summary>
        public int C_Accounts_Policies_Pass_Alpha { get; set; }
        /// <summary>
        /// Enable password expiration
        /// </summary>
        public bool C_Accounts_Policies_Pass_Expiration { get; set; }
        /// <summary>
        /// Expire after (Days)
        /// </summary>
        public int C_Accounts_Policies_Pass_ExpireAfter { get; set; }
        /// <summary>
        /// Passwords cannot be read or exported
        /// </summary>
        public bool C_Accounts_Policies_Pass_DenyExport { get; set; }
        /// <summary>
        /// Allow Admin's password to be exported
        /// </summary>
        public bool C_Accounts_Policies_Pass_AllowAdminPass { get; set; }
    }
}
