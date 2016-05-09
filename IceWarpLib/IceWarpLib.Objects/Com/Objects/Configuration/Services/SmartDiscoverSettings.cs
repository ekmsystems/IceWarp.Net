using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// Smart Discover API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class SmartDiscoverSettings : ComBaseClass
    {
        /// <summary>
        /// SmartDiscover SMTP type
        /// <para>values=(0 - Standard, 1 - TLS/SSL, 2 - 2nd basic port (no SSL))</para>
        /// </summary>
        public SMTPType? C_System_AutoDiscover_SMTPType { get; set; }
        /// <summary>
        /// SmartDiscover SMTP setting
        /// </summary>
        public string C_System_AutoDiscover_SMTP { get; set; }
        /// <summary>
        /// SmartDiscover POP3 setting
        /// </summary>
        public string C_System_AutoDiscover_POP3 { get; set; }
        /// <summary>
        /// SmartDiscover POP3 type
        /// <para>values=(0 - Standard, 1 - TLS/SSL)</para>
        /// </summary>
        public SmartDiscoverType? C_System_AutoDiscover_POP3Type { get; set; }
        /// <summary>
        /// SmartDiscover IMAP setting
        /// </summary>
        public string C_System_AutoDiscover_IMAP { get; set; }
        /// <summary>
        /// SmartDiscover IMAP type
        /// <para>values=(0 - Standard, 1 - TLS/SSL)</para>
        /// </summary>
        public SmartDiscoverType? C_System_AutoDiscover_IMAPType { get; set; }
        /// <summary>
        /// SmartDiscover XMPP setting
        /// </summary>
        public string C_System_AutoDiscover_XMPP { get; set; }
        /// <summary>
        /// SmartDiscover XMPP type
        /// <para>values=(0 - Standard, 1 - TLS/SSL)</para>
        /// </summary>
        public SmartDiscoverType? C_System_AutoDiscover_XMPPType { get; set; }
        /// <summary>
        /// SmartDiscover SIP setting
        /// </summary>
        public string C_System_AutoDiscover_SIP { get; set; }
        /// <summary>
        /// SmartDiscover SIP type
        /// <para>values=(0 - Standard, 1 - TLS/SSL)</para>
        /// </summary>
        public SmartDiscoverType? C_System_AutoDiscover_SIPType { get; set; }

        /// <inheritdoc />
        public SmartDiscoverSettings()
        {
        }

        /// <inheritdoc />
        public SmartDiscoverSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
