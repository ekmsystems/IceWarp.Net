using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Webclient;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Webclient
{
    [TestFixture]
    public class WebclientRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Webclient\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Webclient\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void GetWebmailResource()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetWebmailResource.xml"));
            var request = new GetWebmailResource
            {
                SessionId = "sid",
                Resource = "Test Resource",
                Level = TWebmailSettingLevel.Domain,
                Selector = "testing.co.uk",
                Items = new TPropertyStringList
                {
                    Val = new List<string>
                    {
                        "s_allowconflicts",
                        "s_manager",
                        "s_notificationtomanager",
                        "s_organizersfile",
                        "s_organizersfile_contents",
                        "s_type",
                        "s_unavailable",
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetWebmailResource.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("Test Resource", response.Name);
            Assert.NotNull(response.List);
            Assert.NotNull(response.List.Items);
            Assert.AreEqual(2, response.List.Items.Count);

            Assert.AreEqual(TWebmailSettingAccessLevel.View, response.List.Items.First().DomainAdminAccessLevel);
            Assert.AreEqual(TWebmailSettingAccessLevel.View, response.List.Items.First().UserAccessLevel);
            Assert.AreEqual(TWebmailSettingAccessLevel.Full, response.List.Items.First().AccessLevel);
            Assert.AreEqual("Resource 1 name", response.List.Items.First().Name);
            Assert.AreEqual("Resource 1 value", response.List.Items.First().Value);

            Assert.AreEqual(TWebmailSettingAccessLevel.None, response.List.Items.Last().DomainAdminAccessLevel);
            Assert.AreEqual(TWebmailSettingAccessLevel.None, response.List.Items.Last().UserAccessLevel);
            Assert.AreEqual(TWebmailSettingAccessLevel.Empty, response.List.Items.Last().AccessLevel);
            Assert.AreEqual("Resource 2 name", response.List.Items.Last().Name);
            Assert.AreEqual("Resource 2 value", response.List.Items.Last().Value);
        }

        [Test]
        public void GetWebmailResource_Empty()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetWebmailResource.xml"));
            var request = new GetWebmailResource
            {
                SessionId = "sid",
                Resource = "Test Resource",
                Level = TWebmailSettingLevel.Domain,
                Selector = "testing.co.uk",
                Items = new TPropertyStringList
                {
                    Val = new List<string>
                    {
                        "s_allowconflicts",
                        "s_manager",
                        "s_notificationtomanager",
                        "s_organizersfile",
                        "s_organizersfile_contents",
                        "s_type",
                        "s_unavailable",
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetWebmailResource_Empty.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(String.IsNullOrEmpty(response.Name));
            Assert.NotNull(response.List);
            Assert.NotNull(response.List.Items);
            Assert.AreEqual(0, response.List.Items.Count);
        }
    }
}
