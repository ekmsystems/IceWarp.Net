using System;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Rpc.Requests.Rule;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Rules
{
    [TestFixture]
    public class RulesRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Rules\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Rules\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void GetRulesInfoList()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetRulesInfoList.xml"));
            var request = new GetRulesInfoList
            {
                SessionId = "sid",
                Who = "testing.com",
                Filter = new TRulesListFilter
                {
                    NameMask = "test"
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetRulesInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(2, response.Items.Count);
            Assert.AreEqual(typeof(TRuleTrustedSessionCondition), response.Items.First().Condition.GetType());
            Assert.AreEqual(typeof(TRuleHasAttachmentCondition), response.Items.Last().Condition.GetType());
        }
    }
}
