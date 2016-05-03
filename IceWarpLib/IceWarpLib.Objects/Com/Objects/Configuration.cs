using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Server version
        /// </summary>
        public string C_Version { get; set; }
        /// <summary>
        /// Server release date
        /// </summary>
        public string C_Date { get; set; }
        public string C_Backup { get; set; }
        /// <summary>
        /// Server OS version
        /// </summary>
        public ServerOsVersion C_OS { get; set; }
        /// <summary>
        /// Time zone in seconds
        /// </summary>
        public int C_TimeZone { get; set; }
        /// <summary>
        /// IceWarp Email Server installation path
        /// </summary>
        public string C_InstallPath { get; set; }
        /// <summary>
        /// Path to Config folder
        /// </summary>
        public string C_ConfigPath { get; set; }

        public string C_WebPath { get; set; }

        public string C_SpamPath { get; set; }

        public string C_CalendarPath { get; set; }

        public string C_PathServiceID { get; set; }
        /// <summary>
        /// Require authentification to access Admin console
        /// </summary>
        public bool C_GUI_RequireAuth { get; set; }
        /// <summary>
        /// Use Safe confirmation
        /// </summary>
        public bool C_GUI_SafeConfirm { get; set; }
        /// <summary>
        /// XML license
        /// </summary>
        public string C_License_XMLFile { get; set; }
        /// <summary>
        /// Server license (read/export and add new license)
        /// </summary>
        public string C_License { get; set; }
        /// <summary>
        /// Server reference key
        /// </summary>
        public string C_Reference { get; set; }
        /// <summary>
        /// Retrieve online license using orderid
        /// </summary>
        public string C_OnlineLicense { get; set; }
    }
}
