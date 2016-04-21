using IceWarpLib.Objects.Com.Enums;

namespace IceWarpLib.Objects.Com.Objects.System.SystemTools
{
    public class ServerMigrationTool
    {
        /// <summary>
        /// Enable Migration
        /// </summary>
        public bool C_System_Tools_Migration_Active { get; set; }
        /// <summary>
        /// Migration source host
        /// </summary>
        public string C_System_Tools_Migration_Server { get; set; }
        /// <summary>
        /// Migration service
        /// </summary>
        public ServerMigrationService C_System_Tools_Migration_MigrateService { get; set; }
        /// <summary>
        /// Migration account
        /// </summary>
        public string C_System_Tools_Migration_InfoAccount { get; set; }
        /// <summary>
        /// Path to log file
        /// </summary>
        public string C_System_Tools_Migration_LogFile { get; set; }
        /// <summary>
        /// Access mode
        /// </summary>
        public ServerMigrationAccessMode C_System_Tools_Migration_MessageProcessType { get; set; }
        /// <summary>
        /// Do not use X-Envelope-To header
        /// </summary>
        public bool C_System_Tools_Migration_NoXEnvelopeTo { get; set; }
        /// <summary>
        /// Do not process received header
        /// </summary>
        public bool C_System_Tools_Migration_NoReceived { get; set; }
        /// <summary>
        /// Multidomain migration
        /// </summary>
        public bool C_System_Tools_Migration_MultiDomain { get; set; }
    }
}
