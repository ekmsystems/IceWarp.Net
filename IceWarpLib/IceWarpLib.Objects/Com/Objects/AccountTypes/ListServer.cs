using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class ListServer : Account
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string L_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string L_Name { get; set; }
        /// <summary>
        /// Owner address
        /// </summary>
        public string L_OwnerAddress { get; set; }
        /// <summary>
        /// Members source
        /// </summary>
        public ListServerMembersSource L_SendAllLists { get; set; }
        /// <summary>
        /// Path to list file
        /// </summary>
        public string L_ListFile { get; set; }
        /// <summary>
        /// Subscription
        /// </summary>
        public ListServerSubscription L_DigestConfirmed { get; set; }
        /// <summary>
        /// Commands in subject
        /// </summary>
        public bool L_ListSubject { get; set; }
        /// <summary>
        /// Join right
        /// </summary>
        public bool M_JoinR { get; set; }
        /// <summary>
        /// Leave right
        /// </summary>
        public bool M_LeaveR { get; set; }
        /// <summary>
        /// Lists right
        /// </summary>
        public bool M_ListsR { get; set; }
        /// <summary>
        /// Which right
        /// </summary>
        public bool M_WhichR { get; set; }
        /// <summary>
        /// Review right
        /// </summary>
        public bool M_ReviewR { get; set; }
        /// <summary>
        /// Vacation right
        /// </summary>
        public bool M_VacationR { get; set; }
        /// <summary>
        /// Whitelist right
        /// </summary>
        public bool M_WLR { get; set; }
        /// <summary>
        /// Blacklist right
        /// </summary>
        public bool M_BLR { get; set; }
        /// <summary>
        /// Deliver externally
        /// </summary>
        public bool M_DeliverExternally { get; set; }

        //Lists

        /// <summary>
        /// List server vs mailing list
        /// </summary>
        public bool M_ListServer { get; set; }

        //Options

        /// <summary>
        /// Moderated list server
        /// </summary>
        public bool L_Moderated { get; set; }
        /// <summary>
        /// Moderated password
        /// </summary>
        public string L_ModeratedPassword { get; set; }
        /// <summary>
        /// List server help file
        /// </summary>
        public string M_HelpFile { get; set; }
        /// <summary>
        /// Originator
        /// </summary>
        public Originator L_ListSender { get; set; }
        /// <summary>
        /// Suppress command responses
        /// </summary>
        public bool L_MaxList { get; set; }
        /// <summary>
        /// Access mode - Antivirus
        /// </summary>
        public bool L_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool L_AS { get; set; }
        /// <summary>
        /// Access mode - Quarantine
        /// </summary>
        public bool L_QA { get; set; }

        //Rules

        /// <summary>
        /// Use B&W
        /// </summary>
        public bool L_BlackWhiteFilter { get; set; }
    }
}
