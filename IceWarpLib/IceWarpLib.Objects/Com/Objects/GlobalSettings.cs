using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class GlobalSettings
    {
        //Accounts

        /// <summary>
        /// Maintenance log
        /// </summary>
        public bool C_Accounts_Global_Accounts_MaintenanceLog { get; set; }

        /// <summary>
        /// When the account cache is enabled, information about all accounts from a particular domain is loaded into memory immediately when information about one member of that domain is requested. 
        /// This greatly improves speed of accessing the information next time. 
        /// It works with DB account storage the same way as with file system account storage.
        /// </summary>
        public bool C_Accounts_Global_Accounts_DisableCache { get; set; }

        //Domains

        /// <summary>
        /// Use Domain disk quota 
        /// </summary>
        public bool C_Accounts_Global_Domains_UseDiskQuota { get; set; }
        /// <summary>
        /// Use Domain limits
        /// </summary>
        public bool C_Accounts_Global_Domains_UseDomainLimits { get; set; }
        /// <summary>
        /// Use Domain user limits
        /// </summary>
        public bool C_Accounts_Global_Domains_UseUserLimits { get; set; }
        /// <summary>
        /// Use Domain expiration
        /// </summary>
        public bool C_Accounts_Global_Domains_UseExpiration { get; set; }
        /// <summary>
        /// Override global limits
        /// </summary>
        public bool C_Accounts_Global_Domains_OverrideGlobal { get; set; }
        /// <summary>
        /// Enable DomainKeys support
        /// </summary>
        public bool C_Accounts_Global_Domains_DomainKeys { get; set; }
        /// <summary>
        /// Enable Domain literals
        /// </summary>
        public bool C_Accounts_Global_Domains_Literals { get; set; }
        /// <summary>
        /// Use domain hostnames for outgoing msgs
        /// </summary>
        public bool C_Accounts_Global_Domains_Hostname { get; set; }
        /// <summary>
        /// Use domain IP address for outgoing msgs
        /// </summary>
        public bool C_Accounts_Global_Domains_IPAddress { get; set; }
        /// <summary>
        /// Use Welcome messages
        /// </summary>
        public bool C_Accounts_Global_Domains_WelcomeMsgs { get; set; }
        /// <summary>
        /// Warn when mailbox size exceeds (%)
        /// </summary>
        public int C_Accounts_Global_Domains_WarnMailboxUsage { get; set; }
        /// <summary>
        /// Warn when domain size exceeds (%)
        /// </summary>
        public int C_Accounts_Global_Domains_WarnDomainSize { get; set; }
        /// <summary>
        /// Minutes interval
        /// </summary>
        public int C_Accounts_Global_ActiveDirectorySyncInterval { get; set; }
        /// <summary>
        /// True – after expiration, the account is set to disabled (login, receive).
        /// False – after expiration, the account is set to disabled (login).
        /// </summary>
        public bool C_Accounts_Global_Domains_UserAccountDisabledReceive { get; set; }

        //Advanced

        /// <summary>
        /// LDAP user synchronization
        /// </summary>
        public bool C_Accounts_Global_LDAP_Synchronize { get; set; }
        public string C_Accounts_Global_LDAP_Host { get; set; }
        public string C_Accounts_Global_LDAP_Base { get; set; }
        public string C_Accounts_Global_LDAP_User { get; set; }
        public string C_Accounts_Global_LDAP_Pass { get; set; }
        /// <summary>
        /// If enabled, only primary alias is synchronized to the LDAP server.
        /// </summary>
        public bool C_Accounts_Global_LDAP_SyncPrimaryAliasOnly { get; set; }
        /// <summary>
        /// Number of shown accounts in a domain
        /// </summary>
        public int C_Accounts_Global_Console_ShowAccounts { get; set; }
        /// <summary>
        /// Database account display start position
        /// </summary>
        public int C_Accounts_Global_Console_AccountsPosition { get; set; }
        /// <summary>
        /// Domain list display mode
        /// </summary>
        public DomainListDisplay C_Accounts_Global_Console_DomainDescription { get; set; }
        /// <summary>
        /// Default character replacing spaces in alias. 
        /// Some characters are forbidden – e.g. @. More information: http://tools.ietf.org/html/rfc5322, http://tools.ietf.org/html/rfc5321.
        /// WARNING: Alias must not begin with a white space – the corresponding email address would be invalid.
        /// </summary>
        public char C_Accounts_Global_SpaceReplaceChar { get; set; }
    }
}
