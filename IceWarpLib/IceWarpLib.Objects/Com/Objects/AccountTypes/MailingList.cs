using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class MailingList : Account
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string M_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string M_Name { get; set; }
        /// <summary>
        /// Owner address
        /// </summary>
        public string M_OwnerAddress { get; set; }
        /// <summary>
        /// Members source
        /// </summary>
        public MailingListMembersSource M_SendAllLists { get; set; }
        /// <summary>
        /// Path to list file
        /// </summary>
        public string M_ListFile { get; set; }
        /// <summary>
        /// ODBC connection - DSN,user,pwd,server,type
        /// </summary>
        public string M_ODBC { get; set; }
        /// <summary>
        /// SQL statement
        /// </summary>
        public string M_SQL { get; set; }

        //Message 

        /// <summary>
        /// Set From or Reply-to headers to sender
        /// </summary>
        public MailingListSetSender M_SetSender { get; set; }
        /// <summary>
        /// Set From or Reply-to headers to value
        /// </summary>
        public MailingListSetValue M_SetValue { get; set; }
        /// <summary>
        /// Order of "header value" mode
        /// </summary>
        public MailingListValueMode M_ValueMode { get; set; }
        /// <summary>
        /// From or Reply-to headers value - FromValue|ReplyToValue
        /// </summary>
        public string M_HeaderValue { get; set; }
        /// <summary>
        /// Set Recipients to To: header
        /// </summary>
        public bool M_SeparateTo { get; set; }
        /// <summary>
        /// Add to Subject value
        /// </summary>
        public string M_AddToSubject { get; set; }
        /// <summary>
        /// Add headers value
        /// </summary>
        public string M_AddToHeader { get; set; }
        /// <summary>
        /// Originator
        /// </summary>
        public Originator M_ListSender { get; set; }
        /// <summary>
        /// Header file
        /// </summary>
        public string M_HeaderFile { get; set; }
        /// <summary>
        /// Footer file
        /// </summary>
        public string M_FooterFile { get; set; }

        //Security

        /// <summary>
        /// Only members can post new messages
        /// </summary>
        public bool M_MembersOnly { get; set; }
        /// <summary>
        /// Moderated mode
        /// </summary>
        public Moderation M_Moderated { get; set; }
        /// <summary>
        /// Moderated password
        /// </summary>
        public string M_ModeratedPassword { get; set; }
        /// <summary>
        /// Allow subscribers file
        /// </summary>
        public string M_AllowSubscribers { get; set; }
        /// <summary>
        /// Default rights
        /// </summary>
        public MailingListDefaultRights M_DefaultRights { get; set; }
        /// <summary>
        /// Enable Maximum message size
        /// </summary>
        public bool M_MaxList { get; set; }
        /// <summary>
        /// Maximim message size value (kB)
        /// </summary>
        public int M_MaxListSize { get; set; }
        /// <summary>
        /// Max members
        /// </summary>
        public int M_MaxMembers { get; set; }
        /// <summary>
        /// Deny EXPN
        /// </summary>
        public bool M_DenyEXPNList { get; set; }
        /// <summary>
        /// Access mode - Antivirus
        /// </summary>
        public bool M_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool M_AS { get; set; }
        /// <summary>
        /// Access mode - Quarantine
        /// </summary>
        public bool M_QA { get; set; }

        //Options

        /// <summary>
        /// Send copy to Sender
        /// </summary>
        public bool M_SendToSender { get; set; }
        /// <summary>
        /// Forward copy to owner
        /// </summary>
        public bool M_CopyToOwner { get; set; }
        /// <summary>
        /// Digest mailing list
        /// Relay local messages
        /// </summary>
        public bool M_DigestConfirmed { get; set; }
        /// <summary>
        /// Process mailing list variables
        /// </summary>
        public bool M_ListSubject { get; set; }
        /// <summary>
        /// Personalized mailing list
        /// </summary>
        public bool M_Personalized { get; set; }
        /// <summary>
        /// Remove dead email addresses
        /// </summary>
        public bool M_RemoveDead { get; set; }
        /// <summary>
        /// Max # of messages sent out in 1 minute
        /// </summary>
        public int M_ListBatch { get; set; }
        /// <summary>
        /// Notify owner - Join
        /// </summary>
        public bool M_NotifyJoin { get; set; }
        /// <summary>
        /// Notify owner - Leave
        /// </summary>
        public bool M_NotifyLeave { get; set; }
        /// <summary>
        /// Join file
        /// </summary>
        public string M_SubListFile { get; set; }
        /// <summary>
        /// Leave file
        /// </summary>
        public string M_LeaveFile { get; set; }

        //Rules

        /// <summary>
        /// Use B&W
        /// </summary>
        public bool M_BlackWhiteFilter { get; set; }
    }
}
