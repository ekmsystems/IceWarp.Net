using System;
using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Advanced
{
    /// <summary>
    /// Advanced Extension Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class ExtensionAdvancedSettings : ComBaseClass
    {
        /// <summary>
        /// Disable SSL/TLS
        /// </summary>
        public bool? C_System_Adv_Ext_DisableSSLTLS { get; set; }
        /// <summary>
        /// Enable IPv6 Protocol
        /// </summary>
        public bool? C_System_Adv_Ext_EnableIPv6 { get; set; }
        /// <summary>
        /// Enable Change password server
        /// </summary>
        public bool? C_System_Adv_Ext_ChangePassServer { get; set; }
        /// <summary>
        /// Enable Daytime server
        /// </summary>
        public bool? C_System_Adv_Ext_DaytimeServer { get; set; }
        /// <summary>
        /// Daytime port
        /// </summary>
        public int? C_System_Adv_Ext_DayTimePort { get; set; }
        /// <summary>
        /// Disable Multiple CPU
        /// </summary>
        public bool? C_System_Adv_Ext_DisableMultiCPU { get; set; }
        /// <summary>
        /// Enable SNMP server
        /// </summary>
        public bool? C_System_Adv_Ext_SNMPServer { get; set; }
        /// <summary>
        /// SNMP port
        /// </summary>
        public int? C_System_Adv_Ext_SNMPPort { get; set; }
        /// <summary>
        /// Enable Socks server
        /// </summary>
        public bool? C_System_Adv_Ext_SocksServer { get; set; }
        /// <summary>
        /// Socks port
        /// </summary>
        public int? C_System_Adv_Ext_SocksPort { get; set; }
        /// <summary>
        /// Supported Server SSL Protocol
        /// </summary>
        public SupportedSslProtocol? C_System_Adv_Ext_SSLServerMethod { get; set; }
        /// <summary>
        /// Supported Client SSL Protocol
        /// </summary>
        public SupportedSslProtocol? C_System_Adv_Ext_SSLClientMethod { get; set; }
        /// <summary>
        /// List of supported ciphers according to (http://www.openssl.org/docs/apps/ciphers.html#)
        /// </summary>
        public string C_System_Adv_Ext_SSLCipherList { get; set; }
        /// <summary>
        /// When choosing a cipher, use the server's preferences instead of the client preferences (SSL_OP_CIPHER_SERVER_PREFERENCE in https://www.openssl.org/docs/ssl/SSL_CTX_set_options.html)
        /// </summary>
        public bool? C_System_Adv_Ext_SSLHonorCipherOrder { get; set; }

        /// <inheritdoc />
        public ExtensionAdvancedSettings()
        {
        }

        /// <inheritdoc />
        public ExtensionAdvancedSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
