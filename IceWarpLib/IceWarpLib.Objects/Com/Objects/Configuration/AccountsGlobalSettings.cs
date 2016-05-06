using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration
{
    /// <summary>
    /// Configuration Accounts Global Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class AccountsGlobalSettings : ComBaseClass
    {
        // Accounts
        /// <summary>
        /// Enable User statistics
        /// </summary>
        public bool? C_Accounts_Global_Accounts_UserStat { get; set; }
        /// <summary>
        /// Use Account defaults
        /// </summary>
        public bool? C_Accounts_Global_Accounts_UseDefaults { get; set; }
        /// <summary>
        /// Disables account caching
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DisableCache { get; set; }
        /// <summary>
        /// Maximal number of cached items per domain. Domains wirh less than this number accounts will cache every account. Greater domains will check only recently accessed accounts (such cache can not be used for looping over all domain members)
        /// </summary>
        public int? C_Accounts_Global_Accounts_AccountCache { get; set; }
        /// <summary>
        /// Disables database journal tracking changes in accounts , the journal is used for faster update of account cache - only changed accounts are updated
        /// </summary>
        public bool? C_Accounts_Global_Accounts_Disable_Account_Change_Journal { get; set; }
        /// <summary>
        /// number of miliseconds to wait after wave processes WaveSafecount items, default = 0, which means automated sophisticated choice
        /// </summary>
        public int? C_Accounts_Global_Accounts_DirectoryCacheWaveSleep { get; set; }
        /// <summary>
        /// number of items to process before waiting, default = 0, which means automated sophisticated choice
        /// </summary>
        public int? C_Accounts_Global_Accounts_DirectoryCacheWaveSafeCount { get; set; }
        /// <summary>
        /// Connection string to directory cache database
        /// </summary>
        public string C_Accounts_Global_Accounts_DirectoryCacheConnectionString { get; set; }
        /// <summary>
        /// Schedule data for directorycache
        /// </summary>
        public string C_Accounts_Global_Accounts_DirectoryCacheSchedule { get; set; }//TODO - figure out what gets returned.
        /// <summary>
        /// If set to true, the only one quaery against the directory cache is done at a time  (changing requires restart of all services)
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCacheExclusiveLocking { get; set; }
        /// <summary>
        /// Write only variable , if anything is written there, full refresh of the directorycache is scheduled
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCache_RefreshNow { protected get; set; }
        /// <summary>
        /// If set to true, wave mode processing is interupted and no new wave is started unless this variable is set to false again
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DirectoryCache_WaveStopped { get; set; }
        /// <summary>
        /// Disable transaction usage in directorycache processing
        /// </summary>
        public bool? C_System_Server_DirectoryCacheDontUseTransactions { get; set; }

        // Logging
        /// <summary>
        /// Directory Cache logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_System_Log_Services_DirectoryCache { get; set; }
        /// <summary>
        /// Maintenance logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_Accounts_Global_Accounts_MaintenanceLog { get; set; }
        /// <summary>
        /// Auth logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary, 4 - Extended)</para>
        /// </summary>
        public LoggingLevel? C_Accounts_Global_Accounts_AuthLog { get; set; }
        /// <summary>
        /// Delivery reports
        /// </summary>
        public bool? C_Accounts_Global_Accounts_DeliveryReports { get; set; }
        /// <summary>
        /// Delete delivery report files older then given number of days
        /// </summary>
        public int? C_Accounts_Global_Accounts_DeliveryReportsDeleteOlder { get; set; }
        /// <summary>
        /// enables distributed domains accounts caching
        /// </summary>
        public bool? C_Accounts_Global_Distributed_Accounts_Cache_Enabled { get; set; }
        /// <summary>
        /// Maximal Number of cached items
        /// </summary>
        public int? C_Accounts_Global_Distributed_Accounts_Cache_Max { get; set; }
        /// <summary>
        /// cache expiration in seconds
        /// </summary>
        public int? C_Accounts_Global_Distributed_Accounts_CacheExpire { get; set; }

        // SMTP/POP3/IMAP
        /// <summary>
        /// if set to false, sending to aliases of backup and distributed domains does not rewrite recipients domain with the domain where the alias points to
        /// </summary>
        public bool? C_System_Services_SMTP_Rewrite_Backup_Recipients { get; set; }
        /// <summary>
        /// enables limiting of number of outgoing connections to the same domain per minute
        /// </summary>
        public bool? C_System_Services_SMTP_MaxOutgoingLimitPerDomainEnabled { get; set; }
        /// <summary>
        /// for  C_System_Services_SMTP_MaxOutgoingLimitPerDomainEnabled
        /// </summary>
        public int? C_System_Services_SMTP_MaxOutgoingLimitPerDomainValue { get; set; }
        /// <summary>
        /// enables limiting of number of outgoing connections from the same domain per minute
        /// </summary>
        public bool? C_System_Services_SMTP_MaxSenderLimitPerDomainEnabled { get; set; }
        /// <summary>
        /// Value for C_System_Services_SMTP_MaxSenderLimitPerDomainEnabled
        /// </summary>
        public int? C_System_Services_SMTP_MaxSenderLimitPerDomainValue { get; set; }
        /// <summary>
        /// Experimental - Never set this to true
        /// </summary>
        public bool? C_System_Services_SMTP_SendingStopped { get; set; }
        /// <summary>
        /// When enabled,  user can receive messages even if his mailbox is full, but he can not send any message instead
        /// </summary>
        public bool? C_System_Services_SMTP_SoftQuota { get; set; }

        // Domains
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

        // Advanced
        /// <summary>
        /// One char only, a default character replacing spaces in alias
        /// </summary>
        public char? C_Accounts_Global_SpaceReplaceChar { get; set; }
        /// <summary>
        /// Minutes interval
        /// </summary>
        public int? C_Accounts_Global_ActiveDirectorySyncInterval { get; set; }
        /// <summary>
        /// AD synchronization logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary)</para>
        /// </summary>
        public LoggingLevel? C_System_ADSyncLogType { get; set; }
        /// <summary>
        /// If AD synchronization search returns error, but still some data were returned, Synchronization performs no delete operation by default. Setting this to true enables delete operations for this cases.
        /// </summary>
        public bool? C_System_ADSyncIgnoreSearchError { get; set; }
        /// <summary>
        /// If set to value greater than 0, AD sync performs no delete if it should delete more accounts than this value
        /// </summary>
        public int? C_System_ADSyncMaxDeleteThreshold { get; set; }
        /// <summary>
        /// If set, AD sync will not fill in user's Card with information from AD server
        /// </summary>
        public bool? C_System_ADSyncDisableVCardSync { get; set; }
        /// <summary>
        /// Kerberos Authentication logging level
        /// <para>values=(0 - None, 1 - Debug, 2 - Summary, 3 - Debug & Summary)</para>
        /// </summary>
        public LoggingLevel? C_System_KerberosLogType { get; set; }

        // LDAP
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

        // Console
        /// <summary>
        /// Number of shown accounts in a domain
        /// </summary>
        public int? C_Accounts_Global_Console_ShowAccounts { get; set; }
        /// <summary>
        /// Database account display start position
        /// </summary>
        public int? C_Accounts_Global_Console_AccountsPosition { get; set; }
        /// <summary>
        /// Domain list display mode
        /// <para>values=(0 - Domain, 1 - Description + Domain, 2 - Domain + Description)</para>
        /// </summary>
        public DomainListDisplay? C_Accounts_Global_Console_DomainDescription { get; set; }
        /// <summary>
        /// Account display mode
        /// </summary>
        public int? C_Accounts_Global_Console_AccountDescription { get; set; }

        // Policies
        // Login Policy
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

        // Password policy
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
        public AccountsGlobalSettings()
        {
        }

        /// <inheritdoc />
        public AccountsGlobalSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
