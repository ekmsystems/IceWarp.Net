using System;
using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.Configuration.Tools;
using IceWarpLib.Objects.Exceptions;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.Configuration.Tools
{
    public class MigrationToolSettings_Tests : BaseTest
    {
        [Test]
        public void BuildTPropertyValues_AllProperties()
        {
            var testClass = new MigrationToolSettings
            {
                C_System_Tools_DBMigration_FixUTF8 = true,
                C_System_Tools_Migration_Server = "",
                C_System_Tools_Migration_MigrateService = ServerMigrationService.Both,
                C_System_Tools_Migration_SSLMode = TlsSslMode.Detect,
                C_System_Tools_Migration_InfoAccount = "Info Account"
            };

            var tPropertyValueItems = testClass.BuildTPropertyValues();

            Assert.AreEqual(5, tPropertyValueItems.Count);
            var fixUTF8 = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_DBMigration_FixUTF8");
            Assert.NotNull(fixUTF8);
            Assert.AreEqual(typeof(TPropertyString), fixUTF8.PropertyVal.GetType());
            Assert.AreEqual("1", ((TPropertyString)fixUTF8.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, fixUTF8.PropertyRight);

            var server = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_Migration_Server");
            Assert.NotNull(server);
            Assert.AreEqual(typeof(TPropertyString), server.PropertyVal.GetType());
            Assert.AreEqual("", ((TPropertyString)server.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, server.PropertyRight);

            var migrateService = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_Migration_MigrateService");
            Assert.NotNull(migrateService);
            Assert.AreEqual(typeof(TPropertyString), migrateService.PropertyVal.GetType());
            Assert.AreEqual(((int)ServerMigrationService.Both).ToString(), ((TPropertyString)migrateService.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, migrateService.PropertyRight);

            var sslMode = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_Migration_SSLMode");
            Assert.NotNull(sslMode);
            Assert.AreEqual(typeof(TPropertyString), sslMode.PropertyVal.GetType());
            Assert.AreEqual(((int)TlsSslMode.Detect).ToString(), ((TPropertyString)sslMode.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, sslMode.PropertyRight);

            var infoAccount = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_Migration_InfoAccount");
            Assert.NotNull(infoAccount);
            Assert.AreEqual(typeof(TPropertyString), infoAccount.PropertyVal.GetType());
            Assert.AreEqual("Info Account", ((TPropertyString)infoAccount.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, infoAccount.PropertyRight);
        }

        [Test]
        public void BuildTPropertyValues_SelectProperties()
        {
            var testClass = new MigrationToolSettings
            {
                C_System_Tools_DBMigration_FixUTF8 = true,
                C_System_Tools_Migration_Server = "",
                C_System_Tools_Migration_MigrateService = ServerMigrationService.Both,
                C_System_Tools_Migration_SSLMode = TlsSslMode.Detect,
                C_System_Tools_Migration_InfoAccount = "Info Account"
            };

            var tPropertyValueItems = testClass.BuildTPropertyValues(new List<string> { "C_System_Tools_DBMigration_FixUTF8" });

            Assert.AreEqual(1, tPropertyValueItems.Count);
            var fixUTF8 = tPropertyValueItems.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Tools_DBMigration_FixUTF8");
            Assert.NotNull(fixUTF8);
            Assert.AreEqual(typeof(TPropertyString), fixUTF8.PropertyVal.GetType());
            Assert.AreEqual("1", ((TPropertyString)fixUTF8.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, fixUTF8.PropertyRight);
        }

        [Test]
        public void BuildTPropertyValues_InvalidProperty()
        {
            var testClass = new MigrationToolSettings
            {
                C_System_Tools_DBMigration_FixUTF8 = true,
                C_System_Tools_Migration_Server = "",
                C_System_Tools_Migration_MigrateService = ServerMigrationService.Both,
                C_System_Tools_Migration_SSLMode = TlsSslMode.Detect,
                C_System_Tools_Migration_InfoAccount = "Info Account"
            };

            var invalidPropertyName = "INVALID_PROPERTY";
            var exception = Assert.Throws<SettablePropertyException>(() => testClass.BuildTPropertyValues(new List<string> { invalidPropertyName }));
            Assert.AreEqual(invalidPropertyName, exception.PropertyName);
        }
    }
}
