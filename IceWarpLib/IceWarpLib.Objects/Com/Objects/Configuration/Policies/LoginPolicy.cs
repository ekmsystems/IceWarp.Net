using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Policies
{
    /// <summary>
    /// Login Policy Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class LoginPolicy : ComBaseClass
    {
        /// <summary>
        /// Enable Login policy
        /// </summary>
        public bool? C_Accounts_Policies_Login_Enable { get; set; }
        /// <summary>
        /// Number of failed logins
        /// </summary>
        public int? C_Accounts_Policies_Login_Attempts { get; set; }
        /// <summary>
        /// Block user login for (Min)
        /// </summary>
        public int? C_Accounts_Policies_Login_BlockPeriod { get; set; }
        /// <summary>
        /// Login settings mode
        /// <para>values=(0 - login with username, 1 - login with full email address)</para>
        /// </summary>
        public LoginSetting? C_Accounts_Policies_Login_LoginSettings { get; set; }
        /// <summary>
        /// Login policy mode
        /// <para>values=(0 - Do not block but delay authentication, 1 - Block account for specified time)</para>
        /// </summary>
        public LoginBlock? C_Accounts_Policies_Login_Block { get; set; }
        /// <summary>
        /// Convert chars %/ to @ in username
        /// </summary>
        public bool? C_Accounts_Policies_Login_ConvertChars { get; set; }
        /// <summary>
        /// Enables account IP restriction
        /// </summary>
        public bool? C_Accounts_Policies_Login_IPRestriction { get; set; }
        /// <summary>
        /// Disable logging with domain IP, domain name has to be used
        /// </summary>
        public bool? C_Accounts_Policies_Login_DisableDomainIPLogin { get; set; }
        /// <summary>
        /// Enable super user login
        /// </summary>
        public bool? C_Accounts_Policies_SuperUser { get; set; }
        /// <summary>
        /// Super user password
        /// </summary>
        public string C_Accounts_Policies_SuperUserPassword { get; set; }
        /// <summary>
        /// If enabled, users can login into domain cluster also with their true email (from slave domain)
        /// </summary>
        public bool? C_Accounts_Cluster_AllowSlaveLogin { get; set; }

        /// <inheritdoc />
        public LoginPolicy()
        {
        }

        /// <inheritdoc />
        public LoginPolicy(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
