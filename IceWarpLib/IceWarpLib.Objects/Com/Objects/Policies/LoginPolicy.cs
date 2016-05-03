using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Policies
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class LoginPolicy : ComBaseClass
    {
        /// <summary>
        /// Enable Login policy
        /// </summary>
        public bool C_Accounts_Policies_Login_Enable { get; set; }
        /// <summary>
        /// Number of failed logins
        /// </summary>
        public int C_Accounts_Policies_Login_Attempts { get; set; }
        /// <summary>
        /// Block user login for (Min)
        /// </summary>
        public int C_Accounts_Policies_Login_BlockPeriod { get; set; }
        public LoginBlock C_Accounts_Policies_Login_Block { get; set; }
        /// <summary>
        /// Login settings mode
        /// </summary>
        public LoginSetting C_Accounts_Policies_Login_LoginSettings { get; set; }
        /// <summary>
        /// Convert chars %/ to @ in username
        /// </summary>
        public bool C_Accounts_Policies_Login_ConvertChars { get; set; }
        /// <summary>
        /// Enables account IP restriction
        /// </summary>
        public bool C_Accounts_Policies_Login_IPRestriction { get; set; }
        public bool C_Accounts_Policies_Login_RevealPasswords { get; set; }
        public bool C_Accounts_Policies_Login_DisableDomainIPLogin { get; set; }
        public bool C_Accounts_Policies_SuperUser { get; set; }
        public string C_Accounts_Policies_SuperUserPassword { get; set; }
        public bool C_Accounts_Policies_Login_AuthWISIDDisable { get; set; }
    }
}
