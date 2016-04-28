using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Classes.Statistics;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Statistics;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Statistics
{
    [TestFixture]
    public class StatisticsRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Statistics\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Statistics\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void GetStatisticsProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetStatisticsProperties.xml"));
            var request = new GetStatisticsProperties
            {
                SessionId = "sid",
                StatisticsPropertyList = new TStatisticsPropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{ PropName = "ST_Time" },
                        new TAPIProperty{ PropName = "ST_ServerOut" },
                        new TAPIProperty{ PropName = "ST_ServerIn" },
                        new TAPIProperty{ PropName = "ST_ClientOut" },
                        new TAPIProperty{ PropName = "ST_ClientIn" },
                        new TAPIProperty{ PropName = "ST_Server" },
                        new TAPIProperty{ PropName = "ST_ServerPeak" },
                        new TAPIProperty{ PropName = "ST_Client" },
                        new TAPIProperty{ PropName = "ST_ClientPeak" },
                        new TAPIProperty{ PropName = "ST_ServerConns" },
                        new TAPIProperty{ PropName = "ST_PeakWorkingSetSize" },
                        new TAPIProperty{ PropName = "ST_PageFileUsage" },
                        new TAPIProperty{ PropName = "ST_WorkingSetSize" },
                        new TAPIProperty{ PropName = "ST_RunningTime" },
                        new TAPIProperty{ PropName = "ST_SMTP_MessageOut" },
                        new TAPIProperty{ PropName = "ST_SMTP_MessageIn" },
                        new TAPIProperty{ PropName = "ST_SMTP_MessageFailed" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedGL" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedVirus" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedCF" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedStaticFilter" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedFilter" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedRBL" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedTarpit" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedSpam" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedSpamQuarantine" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedSpamRefused" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedSA" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedCTBulk" },
                        new TAPIProperty{ PropName = "ST_SMTP_FailedCTSpam" },
                        new TAPIProperty{ PropName = "ST_SIP_PacketsIn" },
                        new TAPIProperty{ PropName = "ST_SIP_PacketsOut" },
                        new TAPIProperty{ PropName = "ST_SIP_RTPPacketsIn" },
                        new TAPIProperty{ PropName = "ST_SIP_RTPPacketsOut" }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetStatisticsProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(34, response.Items.Count);
            Assert.AreEqual(typeof(TPropertyNoValue), response.Items.First().PropertyVal.GetType());
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);
        }
    }
}
