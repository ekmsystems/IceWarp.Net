using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Account
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class Group : Account
    {
        /// <summary>
        /// Folder name
        /// </summary>
        public string G_Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string G_Description { get; set; }
        /// <summary>
        /// GroupWare shared
        /// </summary>
        public bool G_GroupwareShared { get; set; }
        /// <summary>
        /// GroupWare default rights
        /// </summary>
        public string G_GroupwareDefaultRights { get; set; }
        /// <summary>
        /// GroupWare mail delivery
        /// </summary>
        public bool G_GroupwareMailDelivery { get; set; }
        /// <summary>
        /// GroupWare members address book
        /// </summary>
        public bool G_GroupwareMembers { get; set; }

        //Members

        /// <summary>
        /// List file
        /// </summary>
        public string G_ListFile { get; set; }

        //Options

        /// <summary>
        /// Moderated mode
        /// </summary>
        public Moderation G_Moderated { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string G_ModeratedPassword { get; set; }
        /// <summary>
        /// Access mode - AntiVirus
        /// </summary>
        public bool G_AVScan { get; set; }
        /// <summary>
        /// Sending of daily agenda to group members
        /// </summary>
        public bool U_GW_DailyAgenda { get; set; }
        /// <summary>
        /// Sending of reminders to group members
        /// </summary>
        public bool U_GW_Reminders { get; set; }

        //Rules

        /// <summary>
        /// Use B&W list
        /// </summary>
        public bool G_BlackWhiteFilter { get; set; }
    }
}
