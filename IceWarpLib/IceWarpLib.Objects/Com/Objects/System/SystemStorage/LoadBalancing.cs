namespace IceWarpLib.Objects.Com.Objects.System.SystemStorage
{
    /// <summary>
    /// Uses RPC GetServerProperties and SetServerProperties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</seealso></para>
    /// </summary>
    public class LoadBalancing : ComBaseClass
    {
        /// <summary>
        /// Server ID
        /// </summary>
        public string C_System_Storage_LB_ServerID { get; set; }
        /// <summary>
        /// Periodically check if settings have been changed and auto-reloaded
        /// </summary>
        public bool C_System_Storage_LB_AutoCheckConfig { get; set; }
        /// <summary>
        /// Default charset for direct mysql client library - as of v5 the default is latin1 so this needs to be changed to utf8
        /// </summary>
        public string C_System_MySQLDefaultCharset { get; set; }
    }
}
