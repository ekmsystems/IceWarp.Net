using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Domain;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Domain
{
    [TestFixture]
    public class DomainRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Domain\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Domain\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void CreateDomain()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "CreateDomain.xml"));
            var request = new CreateDomain
            {
                SessionId = "sid",
                DomainStr = "testing.com",
                DomainProperties = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "d_adminemail"},
                            PropertyVal = new TPropertyString{ Val = "test@testing.com"},
                            PropertyRight = TPermission.ReadWrite
                        },
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "d_mailboxsize"},
                            PropertyVal = new TPropertyString{ Val = "934"},
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "CreateDomain.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteDomain()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteDomain.xml"));
            var request = new DeleteDomain
            {
                SessionId = "sid",
                DomainStr = "testing.com"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteDomain.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void GetDomainAPIConsole()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDomainAPIConsole.xml"));
            var request = new GetDomainAPIConsole
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
                Filter = new TPropertyListFilter
                {
                    Mask = "admin",
                    Groups = new TPropertyStringList { Val = new List<string> { "Domain" } },
                    Clear = false
                },
                Comments = false
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDomainAPIConsole.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(88, response.OverallCount);
            Assert.AreEqual(88, response.Items.Count);
        }

        [Test]
        public void GetDomainAPIConsole_NoFilter()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDomainAPIConsole_NoFilter.xml"));
            var request = new GetDomainAPIConsole
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
                Comments = false
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDomainAPIConsole_TPropertyVals.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(3, response.OverallCount);
            Assert.AreEqual(3, response.Items.Count);

            Assert.AreEqual("d_adminemail", response.Items.First().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.First().PropertyVal.GetType());
            Assert.AreEqual("test@testing.co.uk", ((TPropertyString)response.Items.First().PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);
            Assert.AreEqual(0, response.Items.First().PropertyEnumValues.Items.Count);
            Assert.AreEqual("Domain", response.Items.First().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.String, response.Items.First().PropertyValueType);

            Assert.AreEqual("d_directorycache_refreshnow", response.Items.ElementAt(1).APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyNoValue), response.Items.ElementAt(1).PropertyVal.GetType());
            Assert.AreEqual(TPermission.ReadWrite, response.Items.ElementAt(1).PropertyRight);
            Assert.AreEqual(0, response.Items.ElementAt(1).PropertyEnumValues.Items.Count);
            Assert.AreEqual("Domain", response.Items.ElementAt(1).PropertyGroup);
            Assert.AreEqual(TPropertyValueType.Bool, response.Items.ElementAt(1).PropertyValueType);

            Assert.AreEqual("d_unknownuserstype", response.Items.Last().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.Last().PropertyVal.GetType());
            Assert.AreEqual("0", ((TPropertyString)response.Items.Last().PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
            Assert.NotNull(response.Items.Last().PropertyEnumValues);
            Assert.AreEqual(3, response.Items.Last().PropertyEnumValues.Items.Count);
            Assert.AreEqual("Domain", response.Items.Last().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.Enum, response.Items.Last().PropertyValueType);
        }

        [Test]
        public void GetDomainProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDomainProperties.xml"));
            var request = new GetDomainProperties
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
                DomainPropertyList = new TDomainPropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{ PropName = "d_adminemail"},
                        new TAPIProperty{ PropName = "d_aliases"},
                        new TAPIProperty{ PropName = "d_postmaster"},
                        new TAPIProperty{ PropName = "d_unknownforwardto"},
                        new TAPIProperty{ PropName = "d_unknownuserstype"}
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDomainProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(5, response.Items.Count);

            var adminEmail = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "d_adminemail");
            Assert.NotNull(adminEmail);
            Assert.AreEqual(typeof(TPropertyString), adminEmail.PropertyVal.GetType());
            Assert.AreEqual("test@testing.co.uk", ((TPropertyString)adminEmail.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);

            var aliases = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "d_aliases");
            Assert.NotNull(aliases);
            Assert.AreEqual(typeof(TPropertyString), aliases.PropertyVal.GetType());
            Assert.True(String.IsNullOrEmpty(((TPropertyString)aliases.PropertyVal).Val));
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);

            var postmaster = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "d_postmaster");
            Assert.NotNull(postmaster);
            Assert.AreEqual(typeof(TPropertyString), postmaster.PropertyVal.GetType());
            Assert.AreEqual("postmaster;admin;administrator;supervisor;hostmaster;webmaster;abuse", ((TPropertyString)postmaster.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);

            var unknownForwardTo = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "d_unknownforwardto");
            Assert.NotNull(unknownForwardTo);
            Assert.AreEqual(typeof(TPropertyString), unknownForwardTo.PropertyVal.GetType());
            Assert.True(String.IsNullOrEmpty(((TPropertyString)unknownForwardTo.PropertyVal).Val));
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);

            var unknownUsersType = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "d_unknownuserstype");
            Assert.NotNull(unknownUsersType);
            Assert.AreEqual(typeof(TPropertyString), unknownUsersType.PropertyVal.GetType());
            Assert.AreEqual("0", ((TPropertyString)unknownUsersType.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
        }

        [Test]
        public void GetDomainsInfoList()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDomainsInfoList.xml"));
            var request = new GetDomainsInfoList
            {
                SessionId = "sid",
                Filter = new TDomainListFilter
                {
                    NameMask = "testing.co.uk",
                    TypeMask = TDomainType.Standard
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDomainsInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(1, response.OverallCount);
            Assert.AreEqual(1, response.Items.Count);
            Assert.AreEqual("testing.co.uk", response.Items.First().Name);
            Assert.True(String.IsNullOrEmpty(response.Items.First().Desc));
            Assert.AreEqual(TDomainType.Standard, response.Items.First().DomainType);
            Assert.AreEqual(-5, response.Items.First().AccountCount);
        }

        [Test]
        public void GetDomainsInfoList_NoFilter()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetDomainsInfoList_NoFilter.xml"));
            var request = new GetDomainsInfoList
            {
                SessionId = "sid"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetDomainsInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(1, response.OverallCount);
            Assert.AreEqual(1, response.Items.Count);
            Assert.AreEqual("testing.co.uk", response.Items.First().Name);
            Assert.True(String.IsNullOrEmpty(response.Items.First().Desc));
            Assert.AreEqual(TDomainType.Standard, response.Items.First().DomainType);
            Assert.AreEqual(-5, response.Items.First().AccountCount);
        }

        [Test]
        public void GetMyDomainRights()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetMyDomainRights.xml"));
            var request = new GetMyDomainRigths
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
                DomainPropertyList = new TDomainPropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{ PropName = "d_adminemail"},
                        new TAPIProperty{ PropName = "d_aliases"}
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetMyDomainRights.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(2, response.Items.Count);

            Assert.AreEqual("d_adminemail", response.Items.First().APIProperty.PropName);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);

            Assert.AreEqual("d_aliases", response.Items.Last().APIProperty.PropName);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
        }

        [Test]
        public void RenameDomain()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "RenameDomain.xml"));
            var request = new RenameDomain
            {
                SessionId = "sid",
                OldName = "old.com",
                NewName = "new.com"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "RenameDomain.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
        }
        
        [Test]
        public void SetDomainProperties()
        {
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetDomainProperties.xml"));
            var request = new SetDomainProperties
            {
                SessionId = "sid",
                DomainStr = "testing.com",
                PropertyValueList = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "d_aliases"},
                            PropertyVal = new TPropertyString{ Val = "this-test"},
                            PropertyRight = TPermission.ReadWrite
                        },
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "d_unknownforwardto"},
                            PropertyVal = new TPropertyString{ Val = "forward@email.com"},
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetDomainProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
        }
    }
}
