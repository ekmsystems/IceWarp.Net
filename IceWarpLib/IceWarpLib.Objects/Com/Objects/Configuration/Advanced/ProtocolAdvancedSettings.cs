using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Advanced
{
    /// <summary>
    /// Advanced Protocol Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class ProtocolAdvancedSettings : ComBaseClass
    {
        /// <summary>
        /// Session timeout - 300
        /// </summary>
        public int? C_System_Adv_Protocols_SessionTimeOut { get; set; }
        /// <summary>
        /// Protocol response delay - 0
        /// </summary>
        public int? C_System_Adv_Protocols_ResponseDelay { get; set; }
        /// <summary>
        /// Max number of bad commands - 8
        /// </summary>
        public int? C_System_Adv_Protocols_MaxBadCommands { get; set; }
        /// <summary>
        /// Listen back logs 5
        /// </summary>
        public int? C_System_Adv_Protocols_BackLog { get; set; }
        /// <summary>
        /// DNS Timeout 5
        /// </summary>
        public int? C_System_Adv_Protocols_DNSTimeout { get; set; }
        /// <summary>
        /// Use DNS smart cache
        /// </summary>
        public bool? C_System_Adv_Protocols_DNSCache { get; set; }
        /// <summary>
        /// DNS retries 1
        /// </summary>
        public int? C_System_Adv_Protocols_DNSRetry { get; set; }
        /// <summary>
        /// DNS cache items limit 128
        /// </summary>
        public int? C_System_Adv_Protocols_DNSCacheLimit { get; set; }
        /// <summary>
        /// IMAP timeout
        /// </summary>
        public int? C_System_Adv_Protocols_IMAPTimeout { get; set; }
        /// <summary>
        /// HTTP timeout
        /// </summary>
        public int? C_System_Adv_Protocols_HTTPTimeout { get; set; }
        /// <summary>
        /// XMPP timeout
        /// </summary>
        public int? C_System_Adv_Protocols_XMPPTimeout { get; set; }
        /// <summary>
        /// Timeout for SMTP client sessions
        /// </summary>
        public int? C_System_Adv_Protocols_SMTPClientTimeout { get; set; }

        /// <inheritdoc />
        public ProtocolAdvancedSettings()
        {
        }

        /// <inheritdoc />
        public ProtocolAdvancedSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
