using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Device;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Device
{
    [TestFixture]
    public class DeviceRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Device\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Device\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }
        
        [Test]
        public void DeleteDevices()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteDevices.xml"));
            var request = new DeleteDevices
            {
                SessionId = "sid",
                DevicesList = new TPropertyStringList
                {
                    Val = new List<string>
                    {
                        "abcd1234"
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteDevices.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAllDevices()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAllDevices.xml"));
            var request = new DeleteAllDevices
            {
                SessionId = "sid",
                Who = "test@testing.com",
                Filter = new TMobileDeviceListFilter
                {
                    NameMask = "mask",
                    Status = TMobileDeviceStatus.Allowed,
                    LastSync = 5
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAllDevices.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void GetDeviceProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDeviceProperties.xml"));
            var request = new GetDeviceProperties
            {
                SessionId = "sid",
                DeviceID = "355310042481808",
                DevicePropertyList = new TDevicePropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{ PropName = "Device_Account" }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDeviceProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(1, response.Items.Count);
            Assert.AreEqual(typeof(TPropertyString), response.Items.First().PropertyVal.GetType());
            Assert.AreEqual(TPermission.None, response.Items.First().PropertyRight);
            Assert.AreEqual("Device_Account", response.Items.First().APIProperty.PropName);
            Assert.AreEqual("test@testing.com", ((TPropertyString)response.Items.First().PropertyVal).Val);
        }

        [Test]
        public void GetDevicesInfoList()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDevicesInfoList.xml"));
            var request = new GetDevicesInfoList
            {
                SessionId = "sid",
                Who = "test@testing.com",
                Filter = new TMobileDeviceListFilter
                {
                    NameMask = "mask",
                    Status = TMobileDeviceStatus.Allowed,
                    LastSync = 5
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDevicesInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(1, response.Items.Count);
            Assert.AreEqual("dGVzdEB0ZXN0aW5nLmNvbXxJRA==", response.Items.First().DeviceID);
            Assert.AreEqual("ID", response.Items.First().ID);
            Assert.AreEqual("test@testing.com", response.Items.First().Account);
            Assert.AreEqual("Name", response.Items.First().Name);
            Assert.AreEqual("Device Type", response.Items.First().DeviceType);
            Assert.AreEqual("Model", response.Items.First().Model);
            Assert.AreEqual("Operating System", response.Items.First().OS);
            Assert.AreEqual("Protocol Version", response.Items.First().ProtocolVersion);
            Assert.AreEqual("Registered", response.Items.First().Registered);
            Assert.AreEqual("2016-04-26", response.Items.First().LastSync);
            Assert.AreEqual(TMobileDeviceRemoteWipe.None, response.Items.First().RemoteWipe);
            Assert.AreEqual(TMobileDeviceStatus.Allowed, response.Items.First().Status);
        }

        [Test]
        public void SetAllDevicesStatus()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetAllDevicesStatus.xml"));
            var request = new SetAllDevicesStatus
            {
                SessionId = "sid",
                Who = "test@testing.com",
                Filter = new TMobileDeviceListFilter
                {
                    NameMask = "mask",
                    Status = TMobileDeviceStatus.Allowed,
                    LastSync = 5
                },
                StatusType = TMobileDeviceStatusSet.Allowed
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetAllDevicesStatus.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetDeviceProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetDeviceProperties.xml"));
            var request = new SetDeviceProperties
            {
                SessionId = "sid",
                DeviceID = "355310042481808",
                PropertyValueList = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "Device_Account" },
                            PropertyRight = TPermission.None,
                            PropertyVal = new TPropertyString{ Val = "test@testing.com" }
                        }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetDeviceProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetDeviceStatus()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetDeviceStatus.xml"));
            var request = new SetDeviceStatus
            {
                SessionId = "sid",
                DeviceID = "abcd1234",
                StatusType = TMobileDeviceStatusSet.Allowed
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetDeviceStatus.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetDeviceWipe()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetDeviceWipe.xml"));
            var request = new SetDeviceWipe
            {
                SessionId = "sid",
                DeviceID = "abcd1234",
                WipeType = TMobileDeviceRemoteWipeSet.Soft
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetDeviceWipe.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }
    }
}
