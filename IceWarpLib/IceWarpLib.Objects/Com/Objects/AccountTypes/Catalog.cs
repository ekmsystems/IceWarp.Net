using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.AccountTypes
{
    /// <summary>
    /// Account -> Catalog API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
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
        public bool? T_CatalogSubject { get; set; }
        /// <summary>
        /// Catalog file
        /// </summary>
        public string T_CatalogFile { get; set; }

        // Other
        /// <summary>
        /// Get right
        /// </summary>
        public bool? T_CatalogGet { get; set; }
        /// <summary>
        /// Dir right
        /// </summary>
        public bool? T_CatalogDir { get; set; }
        /// <summary>
        /// SendTo right
        /// </summary>
        public bool? T_CatalogSendTo { get; set; }
        /// <summary>
        /// Originator
        /// <para>values=(0 - Empty, 1 - Sender, 2 - Owner)</para>
        /// </summary>
        public Originator? T_CatalogSender { get; set; }

        // Rules
        /// <summary>
        /// Use Rules
        /// </summary>
        public bool? T_BlackWhiteFilter { get; set; }

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

        /// <inheritdoc />
        public Catalog()
        {
        }

        /// <inheritdoc />
        public Catalog(List<TPropertyValue> valueList) : base(valueList)
        {
        }

    }
}
