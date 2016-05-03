namespace IceWarpLib.Objects.Com.Objects.System.SystemServices
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class LDAPService
    {
        /// <summary>
        /// Enable LDAP service
        /// </summary>
        public bool C_System_Services_LDAP_Enable { get; set; }
        /// <summary>
        /// LDAP service port 389
        /// </summary>
        public int C_System_Services_LDAP_Port { get; set; }
        /// <summary>
        /// LDAP service SSL port 636
        /// </summary>
        public int C_System_Services_LDAP_SSLPort { get; set; }
        /// <summary>
        /// Max number of Incoming connections 256
        /// </summary>
        public int C_System_Services_LDAP_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int C_System_Services_LDAP_Bandwidth { get; set; }
    }
}
