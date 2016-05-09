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
            Assert.AreEqual("d8ffb89b5118a9af489a5c8b921c782546187022f56451987c11faea71a6df3656235a8e6f39eafba250fe45787ddbdd6c801fc8df98565721634d3f15f9f45e718580b42813e0c1f08d08bc675636e5865c770bbd35ab0147fe0f4562a1f71e45d4ba816766d1216562049c3a813c0b98c565f55e93ed2e335d5090bf0dbd01979950f4f06a3464ad1c3661f43df1ef5181fc522d2d4a36c5a8a596113ea26c4a2fba8acf15e08d46dce3f6550e4d57833ed35de4accf66478c65768212699a687e7ed430efa08c744d0ffe5c38550fb1fe8f54f3bcc0758313f9c0278a3ced7de49df579fe9ddc08b7b3b82694100083ae40b5afd1d34f702a07c642eab7dd", response.HashId);
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
