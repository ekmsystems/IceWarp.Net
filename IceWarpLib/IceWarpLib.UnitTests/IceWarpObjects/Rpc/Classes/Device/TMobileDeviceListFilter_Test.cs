using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Device
{
    public class TMobileDeviceListFilter_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <namemask>Name Mask</namemask>
    <status>1</status>
    <lastsync>5</lastsync>
</custom>".TrimStart();

        [Test]
        public void TMobileDeviceListFilter()
        {
            var testClass = new TMobileDeviceListFilter
            {
                NameMask = "Name Mask",
                Status = TMobileDeviceStatus.Allowed,
                LastSync = 5
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TMobileDeviceListFilter_BuildXmlElement()
        {
            var testClass = new TMobileDeviceListFilter(GetXmlNode(_xml));

            Assert.AreEqual("Name Mask", testClass.NameMask);
            Assert.AreEqual(TMobileDeviceStatus.Allowed, testClass.Status);
            Assert.AreEqual(5, testClass.LastSync);
        }
    }
}
