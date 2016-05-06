using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> Notification API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class Notification : Account
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
        public bool? N_IMNotification { get; set; }
        /// <summary>
        /// Max message size (Bytes)
        /// </summary>
        public int? N_Size { get; set; }
        /// <summary>
        /// Split to multiple messages (Messages)
        /// </summary>
        public int? N_Count { get; set; }
        /// <summary>
        /// Filter
        /// <para>values=(0 - All, 1 - None, 2 - Filter)</para>
        /// </summary>
        public NotificationFilter? N_FilterType { get; set; }
        /// <summary>
        /// Send
        /// </summary>
        public bool? N_Send { get; set; }
        /// <summary>
        /// Filter file path
        /// </summary>
        public string N_FilterFile { get; set; }

        // Other
        /// <summary>
        /// Insert information into subject
        /// </summary>
        public bool? N_IntoSubject { get; set; }
        /// <summary>
        /// Insert To: header
        /// </summary>
        public bool? N_SendTo { get; set; }
        /// <summary>
        /// Insert From: header
        /// </summary>
        public bool? N_SendFrom { get; set; }
        /// <summary>
        /// Insert Subject
        /// </summary>
        public bool? N_SendSubject { get; set; }
        /// <summary>
        /// Insert Date/Time
        /// </summary>
        public bool? N_SendDateTime { get; set; }
        /// <summary>
        /// Insert Body
        /// </summary>
        public bool? N_SendBody { get; set; }
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
        /// <para>values=(0 - Empty, 1 - Sender, 2 - Owner)</para>
        /// </summary>
        public Originator? N_Sender { get; set; }

        // Rules
        /// <summary>
        /// Use Rules
        /// </summary>
        public bool? N_BlackWhiteFilter { get; set; }

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

        /// <inheritdoc />
        public Notification()
        {
        }

        /// <inheritdoc />
        public Notification(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
