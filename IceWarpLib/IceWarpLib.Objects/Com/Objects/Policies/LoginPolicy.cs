using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Policies
{
    public class LoginPolicy
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
