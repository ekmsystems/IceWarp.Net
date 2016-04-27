using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Session;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Session
{
    [TestFixture]
    public class SessionRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Session\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Session\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void Authenticate()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "Authenticate.xml"));
            var request = new Authenticate
            {
                AuthType = TAuthType.Plain,
                Digest = "digest",
                Email = "email",
                Password = "password",
                PersistentLogin = false
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "Authenticate.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("201602051125504026", response.SessionId);
        }

        [Test]
        public void GetAuthChallenge()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAuthChallenge.xml"));
            var request = new GetAuthChallenge();
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAuthChallenge.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("auth challenge hash id", response.HashId);
            Assert.AreEqual("2016-04-12 12:08", response.Timestamp.ToString("yyyy-MM-dd HH:mm"));
        }

        [Test]
        public void GetSessionInfo()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetSessionInfo.xml"));
            var request = new GetSessionInfo()
            {
                SessionId = "sid"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetSessionInfo.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("test@testing.co.uk", response.Email);
            Assert.AreEqual("testing.co.uk", response.Domain);
            Assert.AreEqual(TAdminType.DomainAdmin, response.AdminType);
        }

        [Test]
        public void Logout()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "Logout.xml"));
            var request = new Logout
            {
                SessionId = "sid"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "Logout.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
        }
    }
}
