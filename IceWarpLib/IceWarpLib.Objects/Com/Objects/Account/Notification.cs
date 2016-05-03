using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Account
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string N_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string N_Name { get; set; }
        /// <summary>
        /// Notify to:
        /// </summary>
        public string N_NotifyTo { get; set; }
        /// <summary>
        /// IM notification
        /// </summary>
        public bool N_IMNotification { get; set; }
        /// <summary>
        /// Max message size (Bytes) (default 128)
        /// </summary>
        public int N_Size { get; set; }
        /// <summary>
        /// Split to multiple messages (Messages)
        /// </summary>
        public int N_Count { get; set; }
        /// <summary>
        /// Filter
        /// </summary>
        public NotificationFilter N_FilterType { get; set; }
        /// <summary>
        /// Send
        /// </summary>
        public bool N_Send { get; set; }
        /// <summary>
        /// Filter file path
        /// </summary>
        public string N_FilterFile { get; set; }

        //Options

        /// <summary>
        /// Insert information into subject
        /// </summary>
        public bool N_IntoSubject { get; set; }
        /// <summary>
        /// Insert To: header
        /// </summary>
        public bool N_SendTo { get; set; }
        /// <summary>
        /// Insert From: header
        /// </summary>
        public bool N_SendFrom { get; set; }
        /// <summary>
        /// Insert Subject
        /// </summary>
        public bool N_SendSubject { get; set; }
        /// <summary>
        /// Insert Date/Time
        /// </summary>
        public bool N_SendDateTime { get; set; }
        /// <summary>
        /// Insert Body
        /// </summary>
        public bool N_SendBody { get; set; }
        /// <summary>
        /// From:
        /// </summary>
        public string N_From { get; set; }
        /// <summary>
        /// Subject
        /// </summary>
        public string N_Subject { get; set; }
        /// <summary>
        /// Body
        /// </summary>
        public string N_Body { get; set; }
        /// <summary>
        /// Text file
        /// </summary>
        public string N_File { get; set; }
        /// <summary>
        /// Forward to:
        /// </summary>
        public string N_ForwardCopy { get; set; }
        /// <summary>
        /// Originator
        /// </summary>
        public Originator N_Sender { get; set; }
        /// <summary>
        /// Access mode - Antivirus
        /// </summary>
        public bool N_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool N_AS { get; set; }
        /// <summary>
        /// Access mode - Quarantine
        /// </summary>
        public bool N_QA { get; set; }

        //Rules

        /// <summary>
        /// Use B&W list
        /// </summary>
        public bool N_BlackWhiteFilter { get; set; }
    }
}
