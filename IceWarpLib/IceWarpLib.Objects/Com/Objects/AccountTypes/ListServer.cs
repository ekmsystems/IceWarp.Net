using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> ListServer API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
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
        /// <para>values=(0 - List file, 1 - All domain mailing lists)</para>
        /// </summary>
        public ListServerMembersSource? L_SendAllLists { get; set; }
        /// <summary>
        /// path to list file
        /// </summary>
        public string L_ListFile { get; set; }
        /// <summary>
        /// List file contents
        /// </summary>
        public string L_ListFile_Contents { get; set; }
        /// <summary>
        /// Subscription
        /// <para>values=(0 - No confirmation, 1 - User confirmation, 2 - Owner confirmation)</para>
        /// </summary>
        public ListServerSubscription? L_DigestConfirmed { get; set; }
        /// <summary>
        /// Commands in subject
        /// </summary>
        public bool? L_ListSubject { get; set; }
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

        // Options
        /// <summary>
        /// Moderated list server
        /// </summary>
        public bool? L_Moderated { get; set; }
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
        /// <para>values=(0 - Blank, 1 - Sender, 2 - Owner)</para>
        /// </summary>
        public Originator? L_ListSender { get; set; }
        /// <summary>
        /// Suppress command responses
        /// </summary>
        public bool? L_MaxList { get; set; }
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

        // Rules
        public bool? L_BlackWhiteFilter { get; set; }//Use Rules

        //Other
        /// <summary>
        /// List server vs mailing list
        /// </summary>
        public bool? M_ListServer { get; set; }   

        /// <inheritdoc />
        public ListServer()
        {
        }

        /// <inheritdoc />
        public ListServer(List<TPropertyValue> valueList) : base(valueList)
        {
        }

    }
}
