using System.Collections.Generic;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Services
{
    /// <summary>
    /// LDAP Service API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class LDAPServiceSettings : ComBaseClass
    {
        /// <summary>
        /// Enable LDAP service
        /// </summary>
        public bool? C_System_Services_LDAP_Enable { get; set; }
        /// <summary>
        /// LDAP service port - 389
        /// </summary>
        public int? C_System_Services_LDAP_Port { get; set; }
        /// <summary>
        /// LDAP service SSL port - 636
        /// </summary>
        public int? C_System_Services_LDAP_SSLPort { get; set; }
        /// <summary>
        /// Max number of Incoming connections - 256
        /// </summary>
        public int? C_System_Services_LDAP_MaxInConn { get; set; }
        /// <summary>
        /// Max transfer bandwidth (kB/s)
        /// </summary>
        public int? C_System_Services_LDAP_Bandwidth { get; set; }

        /// <inheritdoc />
        public LDAPServiceSettings()
        {
        }

        /// <inheritdoc />
        public LDAPServiceSettings(List<TPropertyValue> valueList) : base(valueList)
        {
        }
    }
}
