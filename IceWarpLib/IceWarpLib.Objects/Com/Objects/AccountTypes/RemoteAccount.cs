using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class RemoteAccount : Account
    {
        /// <summary>
        /// Is this Account Active
        /// </summary>
        public bool RA_Enabled {get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string RA_Name {get; set; }
        /// <summary>
        /// Server
        /// </summary>
        public string RA_Server {get; set; }
        /// <summary>
        /// Server type
        /// </summary>
        public ServerType RA_IMAP {get; set; }
        /// <summary>
        /// Username
        /// </summary>
        public string RA_UserName {get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string RA_Password {get; set; }
        /// <summary>
        /// Logging using APOP
        /// </summary>
        public bool RA_APOP {get; set; }
        /// <summary>
        /// TLS/SSL
        /// </summary>
        public TlsSsl RA_TLSSSL {get; set; }
        /// <summary>
        /// Forward to address
        /// </summary>
        public string RA_ForwardTo {get; set; }
        /// <summary>
        /// Schedule Remote account schedule
        /// </summary>
        public string RA_Schedule { get; set; }

        //Options

        /// <summary>
        /// Notify administrator of session problems
        /// </summary>
        public bool RA_NotifyAdmin {get; set; }
        /// <summary>
        /// Dedupe collected emails
        /// </summary>
        public bool RA_Dedupe {get; set; }
        /// <summary>
        /// Leave messages on server
        /// </summary>
        public bool RA_LeaveMessagesOnServer {get; set; }
        /// <summary>
        /// Delete messages older than (Days)
        /// </summary>
        public bool RA_DeleteOlder {get; set; }
        /// <summary>
        /// Delete if more than (Messages)
        /// </summary>
        public bool RA_DeleteCount {get; set; }
        /// <summary>
        /// Forward extra copy to address
        /// </summary>
        public string RA_ExtraForward {get; set; }
        /// <summary>
        /// Convert domain names
        /// </summary>
        public bool RA_ConvertDomains {get; set; }
        /// <summary>
        /// Email address routing
        /// </summary>
        public bool RA_Routing {get; set; }

        //Domain Pop

        /// <summary>
        /// Domain POP
        /// </summary>
        public bool RA_DomainPOP {get; set; }
        /// <summary>
        /// Do not processed Received: header
        /// </summary>
        public bool RA_NoReceived {get; set; }
        /// <summary>
        /// Stop parsing if Received: yields a local address
        /// </summary>
        public bool RA_ReceiveAll {get; set; }
        /// <summary>
        /// Parse these headers
        /// </summary>
        public bool RA_XEnvelopeTo {get; set; }
        /// <summary>
        /// Real name address matching
        /// </summary>
        public bool RA_NoNames {get; set; }
        /// <summary>
        /// If email:
        /// </summary>
        public string RA_MatchEmail {get; set; }
        /// <summary>
        /// Domain it belongs to
        /// </summary>
        public string RA_DomainString {get; set; }
        /// <summary>
        /// Path to file to keep uids
        /// </summary>
        public string RA_LeaveMessageFile {get; set; }
        /// <summary>
        /// Structure backup
        /// </summary>
        public string RA_Backup {get; set; }
    }
}
