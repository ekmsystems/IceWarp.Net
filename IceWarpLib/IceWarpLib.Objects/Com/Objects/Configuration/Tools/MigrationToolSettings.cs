using System.Collections.Generic;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects.Configuration.Tools
{
    /// <summary>
    /// Migration Tool Settings API variables - listed in C:\Program Files\IceWarp\api\delphi\apiconst.pas
    /// </summary>
    public class MigrationToolSettings : ComBaseClass
    {
        /// <summary>
        /// DB migration - repair UTF-8 character set when migrating
        /// </summary>
        public bool? C_System_Tools_DBMigration_FixUTF8 { get; set; }
        /// <summary>
        /// Enable Migration
        /// </summary>
        public bool? C_System_Tools_Migration_Active { get; set; }
        /// <summary>
        /// Migration source host
        /// </summary>
        public string C_System_Tools_Migration_Server { get; set; }
        /// <summary>
        /// Migration service
        /// </summary>
        public ServerMigrationService? C_System_Tools_Migration_MigrateService { get; set; }
        /// <summary>
        /// Migration service SSL mode
        /// </summary>
        public TlsSslMode? C_System_Tools_Migration_SSLMode { get; set; }
        /// <summary>
        /// Migration account
        /// </summary>
        public string C_System_Tools_Migration_InfoAccount { get; set; }
        /// <summary>
        /// Path to log file
        /// </summary>
        public string C_System_Tools_Migration_LogFile { get; set; }
        /// <summary>
        /// Path to executable to be called after user was created
        /// </summary>
        public string C_System_Tools_Migration_PostMigrateScript { get; set; }
        /// <summary>
        /// Access mode
        /// </summary>
        public ServerMigrationAccessMode? C_System_Tools_Migration_MessageProcessType { get; set; }
        /// <summary>
        /// Do not use X-Envelope-To header
        /// </summary>
        public bool? C_System_Tools_Migration_NoXEnvelopeTo { get; set; }
        /// <summary>
        /// Do not process received header
        /// </summary>
        public bool? C_System_Tools_Migration_NoReceived { get; set; }
        /// <summary>
        /// Multidomain migration
        /// </summary>
        public bool? C_System_Tools_Migration_MultiDomain { get; set; }
        /// <summary>
        /// Only passwords are migrated (users already exists)
        /// </summary>
        public bool? C_System_Tools_Migration_PasswordsOnly { get; set; }
        /// <summary>
        /// Disables check of existence before remote validation
        /// </summary>
        public bool? C_System_Tools_Migration_DisableExistenceChecking { get; set; }

        //Statistics
        /// <summary>
        /// Unix time of start
        /// </summary>
        public int C_System_Tools_Migration_Stat_Start { get; private set; }
        /// <summary>
        /// Total number of migrated mailboxes
        /// </summary>
        public int C_System_Tools_Migration_Stat_TotalUsers { get; private set; }
        /// <summary>
        /// Number of migrated mailboxes
        /// </summary>
        public int C_System_Tools_Migration_Stat_Users { get; private set; }
        /// <summary>
        /// Number of migrated aliases
        /// </summary>
        public int C_System_Tools_Migration_Stat_Aliases { get; private set; }
        /// <summary>
        /// Number of messages migrated
        /// </summary>
        public int C_System_Tools_Migration_Stat_Messages { get; private set; }
        /// <summary>
        /// Unix time of last migrated mailbox
        /// </summary>
        public int C_System_Tools_Migration_Stat_Last { get; private set; }
        /// <summary>
        /// Number of migration errors
        /// </summary>
        public int C_System_Tools_Migration_Stat_Errors { get; private set; }

        /// <inheritdoc />
        public MigrationToolSettings()
        {
        }

        /// <inheritdoc />
        public MigrationToolSettings(List<TPropertyValue> valueList)
            : base(valueList)
        {
        }
    }
}
