using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Global
{
    /// <summary>
    /// Global Accounts LDAP Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class LDAPGlobalSettings : ComBaseClass
    {
        /// <summary>
        /// LDAP user synchronization enable
        /// </summary>
        public bool? C_Accounts_Global_LDAP_Synchronize { get; set; }
        /// <summary>
        /// LDAP user synchronization host
        /// </summary>
        public string C_Accounts_Global_LDAP_Host { get; set; }
        /// <summary>
        /// LDAP user synchronization base DN
        /// </summary>
        public string C_Accounts_Global_LDAP_Base { get; set; }
        /// <summary>
        /// LDAP user synchronization user DN
        /// </summary>
        public string C_Accounts_Global_LDAP_User { get; set; }
        /// <summary>
        /// LDAP user synchronization password
        /// </summary>
        public string C_Accounts_Global_LDAP_Pass { get; set; }
        /// <summary>
        /// [NO EFFECT] windows ldap library is always used on windows
        /// </summary>
        public bool? C_Accounts_Global_LDAP_UseWindowsDLL { get; set; }
        /// <summary>
        /// use NTLM instead of plain auth, requires C_Accounts_Global_LDAP_UseWindowsDLL to be enabled
        /// </summary>
        public bool? C_Accounts_Global_LDAP_UseNTLMAuth { get; set; }
        /// <summary>
        /// If enabled, only primary alias is synced to the LDAP server
        /// </summary>
        public bool? C_Accounts_Global_LDAP_SyncPrimaryAliasOnly { get; set; }
        /// <summary>
        /// Disable password changing in LDAP
        /// </summary>
        public bool? C_Accounts_Global_LDAP_PassChangeDisable { get; set; }

        /// <inheritdoc />
        public LDAPGlobalSettings()
        {
        }

        /// <inheritdoc />
        public LDAPGlobalSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
