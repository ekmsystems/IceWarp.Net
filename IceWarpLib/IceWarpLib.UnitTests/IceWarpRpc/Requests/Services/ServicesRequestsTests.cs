using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Services;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Service;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Services
{
    [TestFixture]
    public class ServicesRequestsTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Services\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Services\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void GetServicesInfoList()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServicesInfoList.xml"));
            var request = new GetServicesInfoList
            {
                SessionId = "sid",
                Filter = new TServiceListFilter()
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServicesInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(21, response.OverallCount);
            Assert.AreEqual(10, response.Items.Count);

            var item1 = response.Items.ElementAt(0);
            Assert.NotNull(item1);
            Assert.AreEqual(TServiceType.SMTP, item1.ServiceType);
            Assert.AreEqual(589075, item1.Uptime);
            Assert.AreEqual(0, item1.Connections);
            Assert.AreEqual(1, item1.MaxConnections);
            Assert.AreEqual(14254080, item1.Data);
            Assert.True(item1.IsRunning);

            var item2 = response.Items.ElementAt(1);
            Assert.NotNull(item2);
            Assert.AreEqual(TServiceType.POP3, item2.ServiceType);

            var item3 = response.Items.ElementAt(2);
            Assert.NotNull(item3);
            Assert.AreEqual(TServiceType.Control, item3.ServiceType);

            var item4 = response.Items.ElementAt(3);
            Assert.NotNull(item4);
            Assert.AreEqual(TServiceType.IM, item4.ServiceType);

            var item5 = response.Items.ElementAt(4);
            Assert.NotNull(item5);
            Assert.AreEqual(TServiceType.Calendar, item5.ServiceType);

            var item6 = response.Items.ElementAt(5);
            Assert.NotNull(item6);
            Assert.AreEqual(TServiceType.Socks, item6.ServiceType);

            var item7 = response.Items.ElementAt(6);
            Assert.NotNull(item7);
            Assert.AreEqual(TServiceType.LDAP, item7.ServiceType);

            var item8 = response.Items.ElementAt(7);
            Assert.NotNull(item8);
            Assert.AreEqual(TServiceType.IMAP, item8.ServiceType);

            var item9 = response.Items.ElementAt(8);
            Assert.NotNull(item9);
            Assert.AreEqual(TServiceType.Antivirus, item9.ServiceType);

            var item10 = response.Items.ElementAt(9);
            Assert.NotNull(item10);
            Assert.AreEqual(TServiceType.FTP, item10.ServiceType);
        }

        [Test]
        public void GetServiceStatistics_POP3()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServiceStatistics_POP3.xml"));
            var request = new GetServiceStatistics
            {
                SessionId = "sid",
                SType = TServiceType.POP3
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServiceStatistics_POP3.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.Statistics);
            Assert.AreEqual(typeof(TServiceBasicStatistics), response.Statistics.GetType());
        }

        [Test]
        public void GetServiceStatistics_SMTP()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServiceStatistics_SMTP.xml"));
            var request = new GetServiceStatistics
            {
                SessionId = "sid",
                SType = TServiceType.SMTP
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServiceStatistics_SMTP.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.Statistics);
            Assert.AreEqual(typeof(TServiceSMTPStatistics), response.Statistics.GetType());
        }

        [Test]
        public void GetServiceStatistics_VOIP()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetServiceStatistics_VOIP.xml"));
            var request = new GetServiceStatistics
            {
                SessionId = "sid",
                SType = TServiceType.SIP
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetServiceStatistics_VOIP.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.Statistics);
            Assert.AreEqual(typeof(TServiceVOIPStatistics), response.Statistics.GetType());
        }

        [Test]
        public void GetTrafficCharts()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetTrafficCharts.xml"));
            var request = new GetTrafficCharts
            {
                SessionId = "sid",
                SType = TServiceType.SMTP,
                ChartType = TServiceChartType.ServerData,
                Count = 10,
                Period = TServiceChartPeriod.Day
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetTrafficCharts.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.List);
            Assert.AreEqual(10, response.List.Items.Count);

            Assert.AreEqual(0.00, response.List.Items.First().V);
            Assert.AreEqual("1461773370", response.List.Items.First().D);
        }

        [Test]
        public void IsServiceRunning()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "IsServiceRunning.xml"));
            var request = new IsServiceRunning
            {
                SessionId = "sid",
                Service = TServiceType.POP3
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "IsServiceRunning.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.IsRunning);
        }

        [Test]
        public void RestartService()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "RestartService.xml"));
            var request = new RestartService
            {
                SessionId = "sid",
                Service = TServiceType.POP3
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "RestartService.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void StartService()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "StartService.xml"));
            var request = new StartService
            {
                SessionId = "sid",
                Service = TServiceType.POP3
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "StartService.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void StopService()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "StopService.xml"));
            var request = new StopService
            {
                SessionId = "sid",
                Service = TServiceType.POP3
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "StopService.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

    }
}
