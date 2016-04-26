using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Device
{
    public class TMobileDeviceInfo_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <deviceid>dGVzdEB0ZXN0aW5nLmNvbXxJRA==</deviceid>
    <id>ID</id>
    <account>test@testing.com</account>
    <name>Name</name>
    <devicetype>Device Type</devicetype>
    <model>Model</model>
    <os>Operating System</os>
    <protocolversion>Protocol Version</protocolversion>
    <registered>Registered</registered>
    <lastsync>2016-04-26</lastsync>
    <remotewipe>1</remotewipe>
    <status>1</status>
</custom>".TrimStart();

        [Test]
        public void TMobileDeviceInfo()
        {
            var testClass = new TMobileDeviceInfo
            {
                DeviceID = "dGVzdEB0ZXN0aW5nLmNvbXxJRA==",
                ID = "ID",
                Account = "test@testing.com",
                Name = "Name",
                DeviceType = "Device Type",
                Model = "Model",
                OS = "Operating System",
                ProtocolVersion = "Protocol Version",
                Registered = "Registered",
                LastSync = "2016-04-26",
                RemoteWipe = TMobileDeviceRemoteWipe.None, 
                Status = TMobileDeviceStatus.Allowed
            };
            
            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TMobileDeviceInfo_BuildXmlElement()
        {
            var testClass = new TMobileDeviceInfo(GetXmlNode(_xml));

            Assert.AreEqual("dGVzdEB0ZXN0aW5nLmNvbXxJRA==", testClass.DeviceID);
            Assert.AreEqual("ID", testClass.ID);
            Assert.AreEqual("test@testing.com", testClass.Account);
            Assert.AreEqual("Name", testClass.Name);
            Assert.AreEqual("Device Type", testClass.DeviceType);
            Assert.AreEqual("Model", testClass.Model);
            Assert.AreEqual("Operating System", testClass.OS);
            Assert.AreEqual("Protocol Version", testClass.ProtocolVersion);
            Assert.AreEqual("Registered", testClass.Registered);
            Assert.AreEqual("2016-04-26", testClass.LastSync);
            Assert.AreEqual(TMobileDeviceRemoteWipe.None, testClass.RemoteWipe);
            Assert.AreEqual(TMobileDeviceStatus.Allowed, testClass.Status);
        }
    }
}
