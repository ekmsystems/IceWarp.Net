using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using IceWarpLib.Objects.Com.Objects.Configuration.Tools;
using IceWarpLib.Objects.Helpers;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Helpers
{
    [TestFixture]
    public class ClassHelperTests
    {
        [Test]
        public void ClassHelper_GetPublicProperties()
        {
            var setterProps = ClassHelper.PublicGetProperites(typeof(WCStatisticsToolSettings));
            Assert.AreEqual(5, setterProps.Count);
            Assert.IsNull(setterProps.FirstOrDefault(x => x.Name == "C_System_Tools_WCStatistics_ExportToXML"));
        }

        [Test]
        public void ClassHelper_GetPublicSetterProperties()
        {
            var setterProps = ClassHelper.SetProperties(typeof(MigrationToolSettings), BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public);
            Assert.AreEqual(14, setterProps.Count);
            Assert.IsNull(setterProps.FirstOrDefault(x => x.Name == "C_System_Tools_Migration_Stat_Errors"));
        }

        [Test]
        public void ComBaseClassTests_GetPublicSetterProperties()
        {
            var testClass = new MigrationToolSettings();
            var setterProps = testClass.SetablePropertiesList();
            Assert.AreEqual(14, setterProps.Count);
            Assert.IsNull(setterProps.FirstOrDefault(x => x.Name == "C_System_Tools_Migration_Stat_Errors"));
        }
    }
}
