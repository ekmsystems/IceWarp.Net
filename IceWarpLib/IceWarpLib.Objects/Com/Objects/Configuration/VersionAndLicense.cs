using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration
{
    /// <summary>
    /// Version & License API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class VersionAndLicense : ComBaseClass
    {
        /// <summary>
        /// Server version [Read only]
        /// </summary>
        public string C_Version { get; protected set; }
        /// <summary>
        /// Settings version [Read only]
        /// </summary>
        public string C_SettingsVersion { get; protected set; }
        /// <summary>
        /// Server release date [Read only]
        /// </summary>
        public string C_Date { get; protected set; }
        /// <summary>
        /// Server settings backup string
        /// </summary>
        public string C_Backup { get; set; }
        /// <summary>
        /// Server OS version [Read only]
        /// <para>values=(0 - Windows, 1 - Linux) </para>
        /// </summary>
        public ServerOsVersion C_OS { get; protected set; }
        /// <summary>
        /// Time zone in seconds [Read only]
        /// </summary>
        public int? C_TimeZone { get; protected set; }
        /// <summary>
        /// Mail server license type [Read only]
        /// <para>values=(1 - Pro, 2 - Standard, 3 - Lite)</para>
        /// </summary>
        public LicenseType C_SuiteType { get; protected set; }
        /// <summary>
        /// Mail server installation path [Read only]
        /// </summary>
        public string C_InstallPath { get; protected set; }
        /// <summary>
        /// Path to Config folder [Read only]
        /// </summary>
        public string C_ConfigPath { get; protected set; }
        /// <summary>
        /// Path to HTML folder [Read only]
        /// </summary>
        public string C_WebPath { get; protected set; }

        // Antispam
        /// <summary>
        /// Path to spam folder [Read only]
        /// </summary>
        public string C_SpamPath { get; protected set; }

        // General
        /// <summary>
        /// Path to calendar folder [Read only]
        /// </summary>
        public string C_CalendarPath { get; protected set; }
        /// <summary>
        /// Load balancing server ID [Read only]
        /// </summary>
        public string C_PathServiceID { get; protected set; }

        // GUI
        /// <summary>
        /// Require Authentication to access Admin console
        /// </summary>
        public bool? C_GUI_RequireAuth { get; set; }
        /// <summary>
        /// Use Safe confirmation
        /// </summary>
        public bool? C_GUI_SafeConfirm { get; set; }
        /// <summary>
        /// If set to true, it is possible to edit sorting string on tab with user vcard
        /// </summary>
        public bool? C_GUI_ShowSortingString { get; set; }

        // General
        /// <summary>
        /// XML decrypted license [Read only] [Display Only]
        /// </summary>
        public string C_License_XML { get; protected set; }
        /// <summary>
        /// Server license (read/export and add new license) [Display Only]
        /// </summary>
        public string C_License { get; protected set; }
        /// <summary>
        /// License status (lsSuccess, lsEvaluation, lsReferenceMismatch, lsRevalidation, lsExpired, lsNone, lsBuildDate)
        /// </summary>
        public int C_LicenseStatus { get; set; }
        /// <summary>
        /// Generate detailed XML report about "used seats" and send it to this email
        /// </summary>
        public string C_License_Modules_Report_Email { get; set; }
        /// <summary>
        /// Returns true when license forbids upgrading the server
        /// </summary>
        public bool? C_License_Expired_For_Upgrade { get; set; }
        /// <summary>
        /// Server reference key [Read only]
        /// </summary>
        public string C_Reference { get; protected set; }
        /// <summary>
        /// Retrieve online license using Order ID
        /// </summary>
        public string C_OnlineLicense { get; set; }
        /// <summary>
        /// Registers trial license, value have to be "Name;Email;Company;Address;ZIP;CountryCode;Phone"
        /// </summary>
        public string C_ObtainTrialLicense { get; set; }
        /// <summary>
        /// Unix timestamp of settings creation [Read only]
        /// </summary>
        public int? C_SettingsTime { get; protected set; }
        /// <summary>
        /// Unix timestamp of evaluation expiration [Read only]
        /// </summary>
        public int? C_EvalExpirationTime { get; protected set; }

        /// <inheritdoc />
        public VersionAndLicense()
        {
        }

        /// <inheritdoc />
        public VersionAndLicense(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
