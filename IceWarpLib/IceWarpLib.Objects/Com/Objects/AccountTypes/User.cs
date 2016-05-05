using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class User : Account
    {
        //Read-only Variables

        /// <summary>
        /// Read only variable to check if the user has quarantine enabled
        /// </summary>
        public bool U_QuarantineSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has antispam enabled
        /// </summary>
        public bool U_ASSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has spam folder enabled
        /// </summary>
        public bool U_SpamFolderSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has SIP enabled
        /// </summary>
        public bool U_SIPSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has IceWarp Anti-Virus enabled
        /// </summary>
        public bool U_AVSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has instant messaging enabled
        /// </summary>
        public bool U_IMSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has GroupWare enabled
        /// </summary>
        public bool U_GWSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has syncML enabled
        /// </summary>
        public bool U_SyncMLSupport { get; protected set; }

        //User

        /// <summary>
        /// Email alias
        /// </summary>
        public string U_EmailAlias { get; set; }
        /// <summary>
        /// Phone alias
        /// </summary>
        public string U_PhoneAlias { get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string U_Mailbox { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string U_Password { get; set; }
        /// <summary>
        /// Authentication mode
        /// </summary>
        public UserAuthMode U_AuthMode { get; set; }
        /// <summary>
        /// Authentication mode value
        /// This variable can also contain a full path to a file. If the path is valid and the file exists, its content is used as U_AuthModeValue. However, it is not possible to combine file paths with server definitions using the "|" (vertical bar) character.
        /// </summary>
        public string U_AuthModeValue { get; set; }
        /// <summary>
        /// User comment
        /// </summary>
        public string U_Comment { get; set; }
        /// <summary>
        /// Mailbox protocol type
        /// </summary>
        public MailboxProtocol U_AccountType { get; set; }
        /// <summary>
        /// Administrator permissions
        /// </summary>
        public bool U_Admin { get; set; }
        /// <summary>
        /// Domain administrator permissions
        /// </summary>
        public bool U_DomainAdmin { get; set; }
        /// <summary>
        /// Forward to address
        /// </summary>
        public string U_ForwardTo { get; set; }
        /// <summary>
        /// Sending of daily agenda to a user
        /// </summary>
        public bool U_GW_DailyAgenda { get; set; }
        /// <summary>
        /// Sending of reminders to a user
        /// </summary>
        public bool U_GW_Reminders { get; set; }

        //Mailbox

        /// <summary>
        /// Mailbox path
        /// </summary>
        public string U_MailBoxPath { get; set; }
        /// <summary>
        /// Full mailbox path
        /// </summary>
        public string U_FullMailboxPath { get; set; }
        /// <summary>
        /// Mailbox local/remote
        /// </summary>
        public bool U_UseRemoteAddress { get; set; }
        /// <summary>
        /// Remote address
        /// </summary>
        public string U_RemoteAddress { get; set; }
        /// <summary>
        /// Null account
        /// </summary>
        public bool U_NULL { get; set; }
        /// <summary>
        /// Enable Delete messages older than
        /// </summary>
        public bool U_DeleteOlder { get; set; }
        /// <summary>
        /// Delete messages older than (Days)
        /// </summary>
        public int U_DeleteOlderDays { get; set; }
        /// <summary>
        /// Enable Forward messages older than
        /// </summary>
        public bool U_ForwardOlder { get; set; }
        /// <summary>
        /// Forward messages older than (Days)
        /// </summary>
        public int U_ForwardOlderDays { get; set; }
        /// <summary>
        /// Forward messages older then x to address
        /// </summary>
        public string U_ForwardOlderTo { get; set; }
        /// <summary>
        /// Copy incoming email address
        /// </summary>
        public string U_MailIn { get; set; }
        /// <summary>
        /// Copy outgoing email address
        /// </summary>
        public string U_MailOut { get; set; }
        /// <summary>
        /// Alternate email
        /// </summary>
        public string U_AlternateEmail { get; set; }

        //Limits

        /// <summary>
        /// Enable mailbox size limit
        /// </summary>
        public bool U_MaxBox { get; set; }
        /// <summary>
        /// Mailbox size limit (kB)
        /// </summary>
        public int U_MaxBoxSize { get; set; }
        /// <summary>
        /// User max message size (kB)
        /// </summary>
        public int U_MaxMessageSize { get; set; }
        /// <summary>
        /// Send out data limit (MB/day)
        /// </summary>
        public int U_MegabyteSendLimit { get; set; }
        /// <summary>
        /// Send out messages limit (#/day)
        /// </summary>
        public int U_NumberSendLimit { get; set; }
        /// <summary>
        /// Account state
        /// </summary>
        public AccountState U_AccountDisabled { get; set; }
        /// <summary>
        /// Expires if inactive for (Days)
        /// </summary>
        public int U_InactiveFor { get; set; }
        /// <summary>
        /// Enable Expires on
        /// </summary>
        public bool U_AccountValid { get; set; }
        /// <summary>
        /// Expires on (Date)
        /// </summary>
        public int U_AccountValidTill { get; set; }
        /// <summary>
        /// Enable Notify before expiration
        /// </summary>
        public bool U_ValidityReport { get; set; }
        /// <summary>
        /// Notify before expiration (Days)
        /// </summary>
        public int U_ValidityReportDays { get; set; }
        /// <summary>
        /// Delete account when expired
        /// </summary>
        public bool U_DeleteExpire { get; set; }
        /// <summary>
        /// Notification file
        /// </summary>
        public string U_ValidReport { get; set; }

        //Options

        /// <summary>
        /// Access mode - SMTP
        /// </summary>
        public bool U_SMTP { get; set; }
        /// <summary>
        /// Access mode - IMAP & POP3
        /// </summary>
        public bool U_POP3IMAP { get; set; }
        /// <summary>
        /// Access mode - Webmail
        /// </summary>
        public bool U_WebMail { get; set; }
        /// <summary>
        /// Access mode - AV
        /// </summary>
        public bool U_AVScan { get; set; }
        /// <summary>
        /// Access mode - AntiSpam
        /// </summary>
        public bool U_AS { get; set; }
        /// <summary>
        /// Access mode - Challenge response
        /// </summary>
        public bool U_Quarantine { get; set; }
        /// <summary>
        /// Access mode - IM
        /// </summary>
        public bool U_IM { get; set; }
        /// <summary>
        /// Access mode - GroupWare
        /// </summary>
        public bool U_GW { get; set; }
        /// <summary>
        /// Access mode - SyncML
        /// </summary>
        public bool U_SyncML { get; set; }
        /// <summary>
        /// Access mode - SIP
        /// </summary>
        public bool U_SIP { get; set; }
        /// <summary>
        /// Quarantine Reports
        /// </summary>
        public AccountQuarantineReports U_QuarantineReports { get; set; }
        /// <summary>
        /// Spam folder mode
        /// </summary>
        public AccountSpamFolder U_SpamFolder { get; set; }
        /// <summary>
        /// Spam administrator
        /// </summary>
        public bool U_SpamAdmin { get; set; }
        /// <summary>
        /// ETRN/ATRN account
        /// </summary>
        public bool U_ETRN { get; set; }
        /// <summary>
        /// Add X-Envelope-To header to all messages
        /// </summary>
        public bool U_XEnvelopeTo { get; set; }
        /// <summary>
        /// No mailing lists
        /// Setting this to true will have the effect of removing this User account from any Mailing list where it not explicitly specified as a member.
        /// For example, if this user is a Domain Admin and a Mailing List has been setup for "Domain Admins" then this user is included unless this variable is set to true.
        /// </summary>
        public bool U_NoMailList { get; set; }
        /// <summary>
        /// User can send to local domains only
        /// </summary>
        public bool U_LocalDomain { get; set; }

        //Responder

        /// <summary>
        /// Auto responder mode
        /// </summary>
        public AutoResponderMode U_Respond { get; set; }
        /// <summary>
        /// Responder period (Days)
        /// </summary>
        public int U_RespondPeriod { get; set; }
        /// <summary>
        /// Responder file
        /// </summary>
        public string U_RespondWith { get; set; }
        /// <summary>
        /// Reply from
        /// </summary>
        public string U_ReplyFrom { get; set; }
        /// <summary>
        /// Responder active from (Date)
        /// </summary>
        public string U_RespondBetweenFrom { get; set; }
        /// <summary>
        /// Responder active till (Date)
        /// </summary>
        public string U_RespondBetweenTo { get; set; }
        /// <summary>
        /// Reply only if to me
        /// </summary>
        public bool U_RespondOnlyIfToMe { get; set; }
        /// <summary>
        /// Auto responder content
        /// </summary>
        public string U_ResponderContent { get; set; }

        //B&W List

        /// <summary>
        /// Use B&W list
        /// </summary>
        public bool U_BlackWhiteFilter { get; set; }
        /// <summary>
        /// Rules content xml
        /// </summary>
        public string U_RulesContentXML { get; set; }
        /// <summary>
        /// IMAP mailbox settings
        /// </summary>
        public string U_IMAPMailbox { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool U_PasswordExpired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int U_MailboxQuota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int U_MailboxSize { get; set; }
    }
}
