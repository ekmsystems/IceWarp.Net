using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.Account
{
    /// <summary>
    /// Uses RPC GetAccountProperties and SetAccountProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetAccountProperties">https://www.icewarp.co.uk/api/#SetAccountProperties</seealso></para>
    /// </summary>
    public class Catalog : Account
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string T_Alias { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string T_Name { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string T_CatalogPass { get; set; }
        /// <summary>
        /// Commands in subject
        /// </summary>
        public bool T_CatalogSubject { get; set; }
        /// <summary>
        /// Catalog file
        /// </summary>
        public string T_CatalogFile { get; set; }

        //Options

        /// <summary>
        /// Get right
        /// </summary>
        public bool T_CatalogGet { get; set; }
        /// <summary>
        ///Dir right
        /// </summary>
        public bool T_CatalogDir { get; set; }
        /// <summary>
        /// SendTo right
        /// </summary>
        public bool T_CatalogSendTo { get; set; }
        /// <summary>
        ///Originator
        /// </summary>
        public Originator T_CatalogSender { get; set; }
        /// <summary>
        /// Access mode - Antivirus 1
        /// </summary>
        public bool T_AVScan { get; set; }
        /// <summary>
        /// Access mode - Antispam
        /// </summary>
        public bool T_AS { get; set; }
        /// <summary>
        /// Access mode - Quarantine
        /// </summary>
        public bool T_QA { get; set; }

        //Rules

        /// <summary>
        /// Use B&W list
        /// </summary>
        public bool T_BlackWhiteFilter { get; set; }

    }
}
