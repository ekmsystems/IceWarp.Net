using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Classes.Server;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Domain;
using IceWarpLib.Rpc.Requests.Server;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Server
{
    [TestFixture]
    public class ServerRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Server\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Server\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void GetAllAPIVariables()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAllAPIVariables.xml"));
            var request = new GetAllAPIVariables
            {
                SessionId = "sid"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAllAPIVariables.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Items.Count);
        }

        [Test]
        public void GetServerAPIConsole()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServerAPIConsole.xml"));
            var request = new GetServerAPIConsole
            {
                SessionId = "sid",
                Filter = new TPropertyListFilter
                {
                    Mask = "",
                    Groups = new TPropertyStringList { Val = new List<string> { "Protocols" } },
                    Clear = true
                },
                Comments = true
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServerAPIConsole.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(0, response.OverallCount);
            Assert.AreEqual(0, response.Items.Count);
        }

        [Test]
        public void GetServerAPIConsole_NoFilter()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServerAPIConsole_NoFilter.xml"));
            var request = new GetServerAPIConsole
            {
                SessionId = "sid",
                Comments = true
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServerAPIConsole.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(0, response.OverallCount);
            Assert.AreEqual(0, response.Items.Count);
        }

        [Test]
        public void GetServerProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServerProperties.xml"));
            var request = new GetServerProperties
            {
                SessionId = "sid",
                ServerPropertyList = new TServerPropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{ PropName = "C_System_Adv_Protocols_SessionTimeOut"},
                        new TAPIProperty{ PropName = "C_System_Adv_Protocols_ResponseDelay"},
                        new TAPIProperty{ PropName = "C_System_Services_LDAP_Enable"}
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServerProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(3, response.Items.Count);

            var sessionTimeout = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Adv_Protocols_SessionTimeOut");
            Assert.NotNull(sessionTimeout);
            Assert.AreEqual(typeof(TPropertyString), sessionTimeout.PropertyVal.GetType());
            Assert.AreEqual("300", ((TPropertyString)sessionTimeout.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);

            var responseDelay = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Adv_Protocols_ResponseDelay");
            Assert.NotNull(responseDelay);
            Assert.AreEqual(typeof(TPropertyString), responseDelay.PropertyVal.GetType());
            Assert.AreEqual("0", ((TPropertyString)responseDelay.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);

            var enableLDAP = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "C_System_Services_LDAP_Enable");
            Assert.NotNull(enableLDAP);
            Assert.AreEqual(typeof(TPropertyString), enableLDAP.PropertyVal.GetType());
            Assert.AreEqual("0", ((TPropertyString)enableLDAP.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
        }

        [Test]
        public void SetServerProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetServerProperties.xml"));
            var request = new SetServerProperties
            {
                SessionId = "sid",
                PropertyValueList = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "C_System_Services_LDAP_Enable"},
                            PropertyVal = new TPropertyString{ Val = "1"},
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetServerProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
        }
    }
}
