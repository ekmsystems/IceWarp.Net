using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Flags;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> Mailing List API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class MailingList : Account
    {
        /// <summary>
        /// Members source
        /// <para>values=(0 - List file, 1 - All current domain users, 2 - All system users, 3 - All domain administrators, 4 - All system administrators, 5 - Members from ODBC)</para>
        /// </summary>
        public MailingListMembersSource? M_SendAllLists { get; set; }
        /// <summary>
        /// Path to list file
        /// </summary>
        public string M_ListFile { get; set; }
        /// <summary>
        /// List file contents
        /// </summary>
        public string M_ListFile_Contents { get; set; }
        /// <summary>
        /// Groupware default rights
        /// </summary>
        public string M_GroupwareDefaultRights { get; set; }
        /// <summary>
        /// ODBC connection - DSN,user,pwd,server,type
        /// </summary>
        public string M_ODBC { get; set; }
        /// <summary>
        /// SQL statement
        /// </summary>
        public string M_SQL { get; set; }

        // Message
        /// <summary>
        /// Set From or Reply-to headers to sender
        /// <para>values=(0 - Off, 1 - Set From: to sender, 2 - Set Reply-To: to sender)</para>
        /// </summary>
        public MailingListSetSender? M_SetSender { get; set; }
        /// <summary>
        /// Set From or Reply-to headers to value
        /// <para>values=(0 - Off, 1 - Set From: to value, 2 - Set Reply-To: to value)</para>
        /// </summary>
        public MailingListSetValue? M_SetValue { get; set; }
        /// <summary>
        /// Order of "header value" mode
        /// <para>values=(0 - From: header set to value, 1 - Reply To: header set to value)</para>
        /// </summary>
        public MailingListValueMode? M_ValueMode { get; set; }
        /// <summary>
        /// From or Reply-to headers value - Pipe separated string
        /// <para>values=(FromValue|ReplyToValue)</para>
        /// </summary>
        public string M_HeaderValue { get; set; }
        /// <summary>
        /// Set Recipients to To: header
        /// </summary>
        public bool? M_SeparateTo { get; set; }
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
        /// <para>values=(0 - Blank, 1 - Sender, 2 - Owner) </para>
        /// </summary>
        public MailingListSetSender? M_ListSender { get; set; }
        /// <summary>
        /// Header file
        /// </summary>
        public string M_HeaderFile { get; set; }
        /// <summary>
        /// Footer file
        /// </summary>
        public string M_FooterFile { get; set; }

        // Security 
        /// <summary>
        /// Only members can post new messages
        /// </summary>
        public bool? M_MembersOnly { get; set; }
        /// <summary>
        /// Moderated mode
        /// <para>values=(0 - None, 1 - Client moderated, 2 - Server moderated) </para>
        /// </summary>
        public Moderation? M_Moderated { get; set; }
        /// <summary>
        /// Moderated password
        /// </summary>
        public string M_ModeratedPassword { get; set; }
        /// <summary>
        /// Allow subscribers file
        /// </summary>
        public string M_AllowSubscribers { get; set; }
        /// <summary>
        /// Default rights - Bit Mask
        /// <para>values=(0 - Receive & post, 3 bits - 1st (Receive), 2nd (Post), 3rd (Digest))</para>
        /// </summary>
        public MailingListDefaultRightsFlag? M_DefaultRights { get; set; }
        /// <summary>
        /// Enable Maximum message size
        /// </summary>
        public bool? M_MaxList { get; set; }
        /// <summary>
        /// Maximim message size value (kB)
        /// </summary>
        public int? M_MaxListSize { get; set; }
        /// <summary>
        /// Deny EXPN
        /// </summary>
        public bool? M_DenyEXPNList { get; set; }

        // Other
        /// <summary>
        /// Send copy to Sender
        /// </summary>
        public bool? M_SendToSender { get; set; }
        /// <summary>
        /// Forward copy to owner
        /// </summary>
        public bool? M_CopyToOwner { get; set; }
        /// <summary>
        /// Digest mailing list
        /// </summary>
        public bool? M_DigestConfirmed { get; set; }
        /// <summary>
        /// Process mailing list variables
        /// </summary>
        public bool? M_ListSubject { get; set; }
        /// <summary>
        /// Personalized mailing list
        /// </summary>
        public bool? M_Personalized { get; set; }
        /// <summary>
        /// Remove dead email addresses
        /// </summary>
        public bool? M_RemoveDead { get; set; }
        /// <summary>
        /// Edit date in message header in moment it goes into outgoing queue
        /// </summary>
        public bool? M_EditSentDate { get; set; }
        /// <summary>
        /// Max # of messages sent out in 1 minute
        /// </summary>
        public int? M_ListBatch { get; set; }
        /// <summary>
        /// Notify owner - Join
        /// </summary>
        public bool? M_NotifyJoin { get; set; }
        /// <summary>
        /// Notify owner - Leave
        /// </summary>
        public bool? M_NotifyLeave { get; set; }
        /// <summary>
        /// Join file
        /// </summary>
        public string M_SubListFile { get; set; }
        /// <summary>
        /// Leave file
        /// </summary>
        public string M_LeaveFile { get; set; }

        // Rulest
        /// <summary>
        /// Use Rules
        /// </summary>
        public bool? M_BlackWhiteFilter { get; set; }
        /// <summary>
        /// Max members
        /// </summary>
        public int? M_MaxMembers { get; set; }
        /// <summary>
        /// LDAP sync
        /// </summary>
        public bool? M_LDAPSync { get; set; }
        /// <summary>
        /// Do not deliver to members with exceeded quotas
        /// </summary>
        public bool? M_CheckMailbox { get; set; }
        /// <summary>
        /// Access mode for Anti-Spam
        /// </summary>
        public bool? M_AS { get; set; }
        /// <summary>
        /// Access mode for Anti-Spam
        /// </summary>
        public bool? M_CR { get; set; }

        //List server
        /// <summary>
        /// Join right
        /// </summary>
        public bool? M_JoinR { get; set; }
        /// <summary>
        /// Leave right
        /// </summary>
        public bool? M_LeaveR { get; set; }
        /// <summary>
        /// Lists right
        /// </summary>
        public bool? M_ListsR { get; set; }
        /// <summary>
        /// Which right
        /// </summary>
        public bool? M_WhichR { get; set; }
        /// <summary>
        /// Review right
        /// </summary>
        public bool? M_ReviewR { get; set; }
        /// <summary>
        /// Vacation right
        /// </summary>
        public bool? M_VacationR { get; set; }
        /// <summary>
        /// Whitelist right
        /// </summary>
        public bool? M_WLR { get; set; }
        /// <summary>
        /// Blacklist right
        /// </summary>
        public bool? M_BLR { get; set; }
        /// <summary>
        /// Deliver externally
        /// </summary>
        public bool? M_DeliverExternally { get; set; }

        //Options
        /// <summary>
        /// List server help file
        /// </summary>
        public string M_HelpFile { get; set; }

        //Other
        /// <summary>
        /// List server vs mailing list
        /// </summary>
        public bool? M_ListServer { get; set; }   

        /// <inheritdoc />
        public MailingList()
        {
        }

        /// <inheritdoc />
        public MailingList(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
