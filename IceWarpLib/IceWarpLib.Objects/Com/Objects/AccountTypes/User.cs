using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> User API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class User : Account
    {
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
        /// <para>values=(0 - Standard, 1 - NT domain, 2 - Active Directory, 3 - Any password)</para>
        /// </summary>
        public UserAuthMode? U_AuthMode { get; set; }
        /// <summary>
        /// Read only - string which should be used for logging into API, respects c_accounts_policies_login_loginsettings
        /// </summary>
        public string U_Login { get; protected set; }
        /// <summary>
        /// Authentication mode value
        /// </summary>
        public string U_AuthModeValue { get; set; }
        /// <summary>
        /// User comment
        /// </summary>
        public string U_Comment { get; set; }
        /// <summary>
        /// Mailbox protocol type
        /// <para>values=(0 - POP3, 1 - IMAP & POP3, 2 - IMAP)</para>
        /// </summary>
        public AccountType? U_AccountType { get; set; }
        /// <summary>
        /// Administrator permission
        /// </summary>
        public bool? U_Admin { get; set; }
        /// <summary>
        /// Domain admin permission
        /// </summary>
        public bool? U_DomainAdmin { get; set; }
        /// <summary>
        /// Gateway admin permission
        /// </summary>
        public bool? U_GatewayAdmin { get; set; }
        /// <summary>
        /// Account state
        /// <para>values=(0 - Enabled, 1 - Disabled (Login), 2 - Disabled (Login, Receive), 3 - Disabled (Tarpitting), 4 - Domain disabled (this value can not be set, it can be only returned in certain situations)</para>
        /// </summary>
        public AccountState? U_AccountDisabled { get; set; }
        /// <summary>
        /// Forward to address
        /// </summary>
        public string U_ForwardTo { get; set; }
        /// <summary>
        /// Do not forward messages marked as spam
        /// </summary>
        public bool? U_DoNotForwardSpam { get; set; }

        //Mailbox
        /// <summary>
        /// Mailbox local
        /// <para>values=(false - Local mailbox, true - Remote address)</para>
        /// </summary>
        public bool? U_UseRemoteAddress { get; set; }
        /// <summary>
        /// Mailbox path
        /// </summary>
        public string U_MailBoxPath { get; set; }
        /// <summary>
        /// Full mailbox path
        /// </summary>
        public string U_FullMailboxPath { get; protected set; }
        /// <summary>
        /// Remote address
        /// </summary>
        public string U_RemoteAddress { get; set; }
        /// <summary>
        /// Enable mailbox size limit
        /// </summary>
        public bool? U_MaxBox { get; set; }
        /// <summary>
        /// Mailbox size limit (kB)
        /// </summary>
        public int? U_MaxBoxSize { get; set; }
        /// <summary>
        /// Send out data limit (MB)
        /// </summary>
        public int? U_MegabyteSendLimit { get; set; }
        /// <summary>
        /// Send out messages limit (#)
        /// </summary>
        public int? U_NumberSendLimit { get; set; }
        /// <summary>
        /// Maximum allowed number of items in inbox
        /// </summary>
        public int? U_InboxCountLimit { get; set; }
        /// <summary>
        /// User max message size (kB)
        /// </summary>
        public int? U_MaxMessageSize { get; set; }
        /// <summary>
        /// Enable Delete messages older than
        /// </summary>
        public bool? U_DeleteOlder { get; set; }
        /// <summary>
        /// Delete messages older than (Days)
        /// </summary>
        public int? U_DeleteOlderDays { get; set; }
        /// <summary>
        /// Enable Forward messages older than
        /// </summary>
        public bool? U_ForwardOlder { get; set; }
        /// <summary>
        /// Forward messages older than (Days)
        /// </summary>
        public int? U_ForwardOlderDays { get; set; }
        /// <summary>
        /// Forward messages older than x to address
        /// </summary>
        public string U_ForwardOlderTo { get; set; }
        /// <summary>
        /// Copy incoming email address
        /// </summary>
        public string U_MailIn { get; set; }
        /// <summary>
        /// Apply CF on incoming mail being copied
        /// </summary>
        public bool? U_MailInUseCF { get; set; }
        /// <summary>
        /// Copy outgoing email address
        /// </summary>
        public string U_MailOut { get; set; }
        /// <summary>
        /// Apply CF on outgoing mail being copied
        /// </summary>
        public bool? U_MailOutUseCF { get; set; }
        /// <summary>
        /// Alternate email
        /// </summary>
        public string U_AlternateEmail { get; set; }

        //Options
        /// <summary>
        /// Null account
        /// </summary>
        public bool? U_NULL { get; set; }
        /// <summary>
        /// ETRN
        /// </summary>
        public bool? U_ETRN { get; set; }
        /// <summary>
        /// Add X-Envelope-To header to all messages
        /// </summary>
        public bool? U_XEnvelopeTo { get; set; }
        /// <summary>
        /// No mailing lists
        /// </summary>
        public bool? U_NoMailList { get; set; }
        /// <summary>
        /// Do not put this user into GAL, unless he is direct member of the group (i.e. his membership is not based on membership in another group )
        /// </summary>
        public bool? U_ExcludeFromGAL { get; set; }
        /// <summary>
        /// Do not put this user into shared IM roster, unless he is directly specified (i.e. his membership is not based on membership in another group )
        /// </summary>
        public bool? U_ExcludeFromSharedRoster { get; set; }
        /// <summary>
        /// User will not be synchronized with Directory Service
        /// </summary>
        public bool? U_ExcludeFromDirectoryServiceSync { get; set; }
        /// <summary>
        /// User can send to local domains only
        /// </summary>
        public bool? U_LocalDomain { get; set; }
        /// <summary>
        /// Expires if inactive for (Days)
        /// </summary>
        public int? U_InactiveFor { get; set; }
        /// <summary>
        /// Enable Expires on
        /// </summary>
        public bool? U_AccountValid { get; set; }
        /// <summary>
        /// Expires on (Number of days from 1899/12/30)
        /// </summary>
        public int? U_AccountValidTill { get; set; }
        /// <summary>
        /// Expires on (Date in yyyy/mm/dd format)
        /// </summary>
        public DateTime? U_AccountValidTill_Date { get; set; }
        /// <summary>
        /// Enable Notify before expiration
        /// </summary>
        public bool? U_ValidityReport { get; set; }
        /// <summary>
        /// Notify before expiration (Days)
        /// </summary>
        public int? U_ValidityReportDays { get; set; }
        /// <summary>
        /// Delete account when expired
        /// </summary>
        public bool? U_DeleteExpire { get; set; }
        /// <summary>
        /// Notification file
        /// </summary>
        public string U_ValidReport { get; set; }

        //Miscellaneous
        /// <summary>
        /// Spam folder mode
        /// <para>values=(0 - Default, 1 - Do not use Spam folder, 2 - Use Spam folder)</para>
        /// </summary>
        public AccountSpamFolder? U_SpamFolder { get; set; }
        /// <summary>
        /// Spam reports mode
        /// <para>Enum values=(0 - Disabled, 1 - Default, 2 - New Items only, 3 - All items)</para>
        /// </summary>
        public AccountQuarantineReports? U_QuarantineReports { get; set; }
        /// <summary>
        /// Spam administrator
        /// </summary>
        public bool? U_SpamAdmin { get; set; }
        /// <summary>
        /// Policy - SMTP
        /// </summary>
        public bool? U_SMTP { get; set; }
        /// <summary>
        /// Policy - IMAP & POP3
        /// </summary>
        public bool? U_POP3IMAP { get; set; }
        /// <summary>
        /// Policy - WebClient
        /// </summary>
        public bool? U_WebMail { get; set; }
        /// <summary>
        /// Policy - AV
        /// </summary>
        public bool? U_AVScan { get; set; }
        /// <summary>
        /// Policy - AntiSpam
        /// </summary>
        public bool? U_AS { get; set; }
        /// <summary>
        /// Policy - Challenge response
        /// </summary>
        public bool? U_Quarantine { get; set; }
        /// <summary>
        /// Policy - IM
        /// </summary>
        public bool? U_IM { get; set; }
        /// <summary>
        /// Policy - Groupware
        /// </summary>
        public bool? U_GW { get; set; }
        /// <summary>
        /// Policy - SIP
        /// </summary>
        public bool? U_SIP { get; set; }
        /// <summary>
        /// Policy - SyncML
        /// </summary>
        public bool? U_SyncML { get; set; }
        /// <summary>
        /// Policy - FTP
        /// </summary>
        public bool? U_FTP { get; set; }
        /// <summary>
        /// Policy - SMS
        /// </summary>
        public bool? U_SMS { get; set; }
        /// <summary>
        /// Policy - ActiveSync
        /// </summary>
        public bool? U_ActiveSync { get; set; }
        /// <summary>
        /// Policy - WebDav
        /// </summary>
        public bool? U_WebDAV { get; set; }
        /// <summary>
        /// Policy - Archive
        /// </summary>
        public bool? U_Archive { get; set; }
        /// <summary>
        /// User is logged into local VOIP service. Read only
        /// </summary>
        public bool? U_SIP_ONLINE { get; protected set; }
        /// <summary>
        /// User is logged into local VOIP service and is not calling now. Read only
        /// </summary>
        public bool? U_SIP_AVAILABLE { get; protected set; }
        /// <summary>
        /// User is logged into local IM service. Read only
        /// </summary>
        public bool? U_IM_ONLINE { get; protected set; }
        /// <summary>
        /// Raw contents of user roster file
        /// </summary>
        public string U_IM_ROSTER_CONTENTS { get; set; } 
        /// <summary>
        /// List of groups where user is member of. Computed online, read only
        /// </summary>
        public string U_GROUPS { get; protected set; }
        /// <summary>
        /// List of groups where user is member of, including all combinations of aliases
        /// </summary>
        public string U_GROUPSLIST { get; set; }
        /// <summary>
        /// User account blocked due to Login policy. Write 0 here to unblock.
        /// </summary>
        public bool? U_Blocked { get; set; }

        //Responder
        /// <summary>
        /// Autoresponder mode
        /// <para>Enum values=(0 - Do not respond, 1 - Respond always, 2 - Respond once, 3 - Respond once in period)</para>
        /// </summary>
        public AutoResponderMode? U_Respond { get; set; }
        /// <summary>
        /// Responder period (Days)
        /// </summary>
        public int? U_RespondPeriod { get; set; }
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
        public DateTime? U_RespondBetweenFrom { get; set; }
        /// <summary>
        /// Responder active till (Date)
        /// </summary>
        public DateTime? U_RespondBetweenTo { get; set; }
        /// <summary>
        /// Reply only if to me
        /// </summary>
        public bool? U_RespondOnlyIfToMe { get; set; }
        /// <summary>
        /// Auto responder content
        /// </summary>
        public string U_ResponderContent { get; set; }
        /// <summary>
        /// List of emails or domains where to not autorespond
        /// </summary>
        public string U_NoRespondFor { get; set; }
        /// <summary>
        /// Read only variable to check if the user has quarantine enabled
        /// </summary>
        public bool? U_QuarantineSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has antispam enabled
        /// </summary>
        public bool? U_ASSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has spam folder enabled
        /// </summary>
        public bool? U_SpamFolderSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has SIP enabled
        /// </summary>
        public bool? U_SIPSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has antivirus enabled
        /// </summary>
        public bool? U_AVSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has instant messaging enabled
        /// </summary>
        public bool? U_IMSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has groupware enabled
        /// </summary>
        public bool? U_GWSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user can use sharing
        /// </summary>
        public bool? U_SharingAvailable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has syncML enabled
        /// </summary>
        public bool? U_SyncMLSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has FTP enabled
        /// </summary>
        public bool? U_FTPSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has SMS enabled
        /// </summary>
        public bool? U_SMSSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has ActiveSync enabled
        /// </summary>
        public bool? U_ActiveSyncSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has WebDAV enabled
        /// </summary>
        public bool? U_WebDAVSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has Archive enabled
        /// </summary>
        public bool? U_ArchiveSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has WebMeetings enabled
        /// </summary>
        public bool? U_MeetingSupport { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has Cisco Integration enabled
        /// </summary>
        public bool? U_CiscoSupport { get; protected set; }
        /// <summary>
        /// SMS file content
        /// </summary>
        public string U_SMSContent { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has quarantine Editable
        /// </summary>
        public bool? U_QuarantineEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has antispam Editable
        /// </summary>
        public bool? U_ASEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has SIP Editable
        /// </summary>
        public bool? U_SIPEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has antivirus Editable
        /// </summary>
        public bool? U_AVEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has instant messaging Editable
        /// </summary>
        public bool? U_IMEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has groupware Editable
        /// </summary>
        public bool? U_GWEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has syncML Editable
        /// </summary>
        public bool? U_SyncMLEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has FTP Editable
        /// </summary>
        public bool? U_FTPEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has SMS Editable
        /// </summary>
        public bool? U_SMSEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has ActiveSync Editable
        /// </summary>
        public bool? U_ActiveSyncEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has WebDAV Editable
        /// </summary>
        public bool? U_WebDAVEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has Archive Editable
        /// </summary>
        public bool? U_ArchiveEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has WebMeetings editable
        /// </summary>
        public bool? U_MeetingEditable { get; protected set; }
        /// <summary>
        /// Read only variable to check if the user has Cisco Integration editable
        /// </summary>
        public bool? U_CiscoEditable { get; protected set; }

        //Rules
        /// <summary>
        /// Use Rules
        /// </summary>
        public bool? U_BlackWhiteFilter { get; set; }
        /// <summary>
        /// Rules content xml [D]
        /// </summary>
        public string U_RulesContentXML { get; protected set; }
        /// <summary>
        /// IMAP mailbox settings
        /// </summary>
        public string U_IMAPMailbox { get; set; }
        /// <summary>
        /// Status of user password expiration
        /// <para></para>
        /// </summary>
        public bool? U_PasswordExpired { get; set; }
        /// <summary>
        /// Read only, effective mailbox quota in kB
        /// </summary>
        public int? U_MailboxQuota { get; protected set; }
        /// <summary>
        /// Read only, current mailbox size in kB
        /// </summary>
        public int? U_MailboxSize { get; protected set; }
        /// <summary>
        /// Outlook Sync activation key
        /// </summary>
        public string U_ActivationKey_OutConn { get; protected set; }
        /// <summary>
        /// Desktop Client activation key
        /// </summary>
        public string U_ActivationKey_Desktop { get; protected set; }
        /// <summary>
        /// Policy - Outlook Sync
        /// </summary>
        public bool? U_Client_Connector { get; set; }
        /// <summary>
        /// Policy - Desktop Client
        /// </summary>
        public bool? U_Client_Desktop { get; set; }
        /// <summary>
        /// XML representation of VoIP call forwarding settings
        /// </summary>
        public string U_SIP_CallTransfer { get; set; }
        /// <summary>
        /// VoIP call forwarding enabled
        /// </summary>
        public bool? U_SIP_CallTransferActive { get; set; }
        /// <summary>
        /// VoIP call forwarding target
        /// </summary>
        public string U_SIP_CallTransferTarget { get; set; }
        /// <summary>
        /// VoIP call forwarding timeout (forward after) in seconds
        /// </summary>
        public int? U_SIP_CallTransferTime { get; set; }
        /// <summary>
        /// Number of SMS sent last month
        /// </summary>
        public int? U_SMS_SentLastMonth { get; protected set; }
        /// <summary>
        /// Number of SMS sent this month
        /// </summary>
        public int? U_SMS_SentThisMonth { get; protected set; }
        /// <summary>
        /// Number of SMS allowed to send this month
        /// </summary>
        public int? U_SMS_SendLimit { get; protected set; }
        /// <summary>
        /// Gateway ID
        /// </summary>
        public string U_SMS_GatewayId { get; set; }
        /// <summary>
        /// Expire Date
        /// </summary>
        public DateTime? U_SMS_ExpireDate { get; set; }
        /// <summary>
        /// User access mode for meeting
        /// </summary>
        public bool? U_Meeting { get; set; }
        /// <summary>
        /// User access mode for cisco integration
        /// </summary>
        public bool? U_Cisco { get; set; }
        /// <summary>
        /// Write only variable , if anything is written there, refresh of the directorycache  of this account is scheduled
        /// </summary>
        public bool? U_DirectoryCache_RefreshNow { get; set; }
        /// <summary>
        /// One char only, status of ABQ
        /// </summary>
        public char? U_ABQStatus { get; set; }
        /// <summary>
        /// Special Readonly info for local WCS service - url encoded list, history_supported,filetransfer_supported
        /// </summary>
        public string U_XMPP_SUPPORT_DATA { get; protected set; }
        /// <summary>
        /// Special Readonly info for local WCS service - url encoded list - encryptedpassword,username,domain,host
        /// </summary>
        public string U_XMPP_DATA { get; protected set; }
        /// <summary>
        /// Special Readonly info for SIP service - url encoded list - password,username,extension,host
        /// </summary>
        public string U_SIP_DATA { get; protected set; }
        /// <summary>
        /// User level of SMS settings
        /// </summary>
        public string U_SMS_UserSettings { get; set; }
        /// <summary>
        /// User level of FTP settings
        /// </summary>
        public string U_FTP_UserSettings { get; set; }
        /// <summary>
        /// Temporary disable password policy for the current session
        /// </summary>
        public bool? U_PASS_POLICY_Temporary_Disable { get; set; }

        /// <inheritdoc />
        public User()
        {
        }

        /// <inheritdoc />
        public User(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
