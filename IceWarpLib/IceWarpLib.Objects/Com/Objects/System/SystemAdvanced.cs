using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class SystemAdvanced
    {
        /// <summary>
        /// Session timeout - 300
        /// </summary>
        public int C_System_Adv_Protocols_SessionTimeOut { get; set; }
        /// <summary>
        /// Protocol response delay - 0
        /// </summary>
        public int C_System_Adv_Protocols_ResponseDelay { get; set; }
        /// <summary>
        /// Max number of bad commands - 8
        /// </summary>
        public int C_System_Adv_Protocols_MaxBadCommands { get; set; }
        /// <summary>
        /// Listen back logs 5
        /// </summary>
        public int C_System_Adv_Protocols_BackLog { get; set; }
        /// <summary>
        /// DNS Timeout 5
        /// </summary>
        public int C_System_Adv_Protocols_DNSTimeout { get; set; }
        /// <summary>
        /// Use DNS smart cache
        /// </summary>
        public bool C_System_Adv_Protocols_DNSCache { get; set; }
        /// <summary>
        /// DNS retries 1
        /// </summary>
        public int C_System_Adv_Protocols_DNSRetry { get; set; }
        /// <summary>
        /// DNS cache items limit 128
        /// </summary>
        public int C_System_Adv_Protocols_DNSCacheLimit { get; set; }
        /// <summary>
        /// IMAP timeout
        /// </summary>
        public int C_System_Adv_Protocols_IMAPTimeout { get; set; }
        /// <summary>
        /// Disable SSL/TLS
        /// </summary>
        public bool C_System_Adv_Ext_DisableSSLTLS { get; set; }
        /// <summary>
        /// Enable IPv6 Protocol
        /// </summary>
        public bool C_System_Adv_Ext_EnableIPv6 { get; set; }
        /// <summary>
        /// Enable Change password server
        /// </summary>
        public bool C_System_Adv_Ext_ChangePassServer { get; set; }
        /// <summary>
        /// Enable Daytime server
        /// </summary>
        public bool C_System_Adv_Ext_DaytimeServer { get; set; }
        /// <summary>
        /// Daytime port
        /// </summary>
        public int C_System_Adv_Ext_DayTimePort { get; set; }
        /// <summary>
        /// Disable Multiple CPU
        /// </summary>
        public bool C_System_Adv_Ext_DisableMultiCPU { get; set; }
        /// <summary>
        /// Enable SNMP server
        /// </summary>
        public bool C_System_Adv_Ext_SNMPServer { get; set; }
        /// <summary>
        /// SNMP port
        /// </summary>
        public int C_System_Adv_Ext_SNMPPort { get; set; }
        /// <summary>
        /// Enable Socks server
        /// </summary>
        public bool C_System_Adv_Ext_SocksServer { get; set; }
        /// <summary>
        /// Socks port
        /// </summary>
        public int C_System_Adv_Ext_SocksPort { get; set; }
        /// <summary>
        /// Supported Server SSL Protocol
        /// </summary>
        public SupportedSslProtocol C_System_Adv_Ext_SSLServerMethod { get; set; }
        /// <summary>
        /// Supported Client SSL Protocol
        /// </summary>
        public SupportedSslProtocol C_System_Adv_Ext_SSLClientMethod { get; set; }
    }
}
