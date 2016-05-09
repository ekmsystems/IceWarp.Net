using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Requests.Account;
using IceWarpLib.Rpc.Utilities;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpRpc.Requests.Account
{
    [TestFixture]
    public class AccountRequestTests
    {
        private readonly string _requestsTestDataPath = @"IceWarpRpc\Requests\Account\TestData\Requests";
        private readonly string _responsesTestDataPath = @"IceWarpRpc\Requests\Account\TestData\Responses";

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void AddAccountMembers()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "AddAccountMembers.xml"));
            var request = new AddAccountMembers
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                Members = new TPropertyMembers
                {
                    Val = new List<TPropertyMember>
                    {
                        new TPropertyMember
                        {
                            Default = true,
                            Digest = true,
                            Post = true,
                            Recieve = true,
                            Val = "Member 1"
                        },
                        new TPropertyMember
                        {
                            Default = true,
                            Digest = false,
                            Post = false,
                            Recieve = true,
                            Val = "Member 2"
                        }
                    }
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "AddAccountMembers.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void AddAllAccountMembers()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "AddAllAccountMembers.xml"));
            var request = new AddAllAccountMembers
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                DomainStr = "testing.com",
                Filter = new TAccountListFilter
                {
                    NameMask = "Alias",
                    TypeMask = AccountType.MailingList
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "AddAllAccountMembers.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void CreateAccount()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "CreateAccount.xml"));
            var request = new CreateAccount
            {
                SessionId = "sid",
                DomainStr = "testing.com",
                AccountProperties = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "u_name"},
                            PropertyVal = new TPropertyString{ Val = "testing"},
                            PropertyRight = TPermission.ReadWrite
                        },
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "u_alias"},
                            PropertyVal = new TPropertyString{ Val = "tester"},
                            PropertyRight = TPermission.ReadWrite
                        },
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "u_type"},
                            PropertyVal = new TPropertyString{ Val = AccountType.User.ToString("d")},
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "CreateAccount.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAccounts()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAccounts.xml"));
            var request = new DeleteAccounts
            {
                SessionId = "sid",
                DomainStr = "testing.com",
                AccountList = new TPropertyStringList
                {
                    Val = new List<string> { "delete1", "delete2" }
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAccounts.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAllAccounts()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAllAccounts.xml"));
            var request = new DeleteAllAccounts
            {
                SessionId = "sid",
                DomainStr = "testing.com",
                Filter = new TAccountListFilter
                {
                    NameMask = "Alias",
                    TypeMask = AccountType.StaticRoute
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAllAccounts.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAllAccounts_NoFilter()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAllAccounts_NoFilter.xml"));
            var request = new DeleteAllAccounts
            {
                SessionId = "sid",
                DomainStr = "testing.com"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAllAccounts.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAccountMembers()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAccountMembers.xml"));
            var request = new DeleteAccountMembers
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                Members = new TPropertyMembers
                {
                    Val = new List<TPropertyMember>
                    {
                        new TPropertyMember
                        {
                            Default = true,
                            Digest = true,
                            Post = true,
                            Recieve = true,
                            Val = "Member 1"
                        },
                        new TPropertyMember
                        {
                            Default = true,
                            Digest = false,
                            Post = false,
                            Recieve = true,
                            Val = "Member 2"
                        }
                    }
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAccountMembers.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void DeleteAllAccountMembers()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "DeleteAllAccountMembers.xml"));
            var request = new DeleteAllAccountMembers
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "DeleteAllAccountMembers.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void ExpireAccountPassword()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "ExpireAccountPassword.xml"));
            var request = new ExpireAccountPassword
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "ExpireAccountPassword.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void GenerateAccountActivationKey()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GenerateAccountActivationKey.xml"));
            var request = new GenerateAccountActivationKey
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                KeyType = TActivationKeyType.DesktopClient,
                Count = "10",
                Description = "key description"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GenerateAccountActivationKey.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("mz2jvh", response.ActivationKey);
        }

        [Test]
        public void GenerateAccountPassword()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GenerateAccountPassword.xml"));
            var request = new GenerateAccountPassword
            {
                SessionId = "sid"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GenerateAccountPassword.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("mz2jvh", response.Password);
        }

        [Test]
        public void GetAccountAdministrativePermissions()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountAdministrativePermissions.xml"));
            var request = new GetAccountAdministrativePermissions
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountAdministrativePermissions.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.DomainsPermissions);
            Assert.AreEqual(1, response.DomainsPermissions.Items.Count);
            Assert.AreEqual(1, response.DomainsPermissions.Items.First().DomainsSet.Items.Count);
            Assert.AreEqual("testing.com", response.DomainsPermissions.Items.First().DomainsSet.Items.First().Mask);
            Assert.AreEqual(1, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.AccountsRelatedPermissions.Items.Count);
            Assert.AreEqual(1, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.AccountsRelatedPermissions.Items.First().Prop);
            Assert.AreEqual(TPermission.ReadWrite, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.AccountsRelatedPermissions.Items.First().Perm);
            Assert.AreEqual(1, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.DomainRelatedPermissions.Items.Count);
            Assert.AreEqual(1, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.DomainRelatedPermissions.Items.First().Prop);
            Assert.AreEqual(TPermission.ReadWrite, response.DomainsPermissions.Items.First().DomainsAdministrativePermissions.DomainRelatedPermissions.Items.First().Perm);

            Assert.NotNull(response.GlobalPermissions);
            Assert.AreEqual(1, response.GlobalPermissions.Items.Count);
            Assert.AreEqual(1, response.GlobalPermissions.Items.First().Prop);
            Assert.AreEqual(TPermission.ReadWrite, response.GlobalPermissions.Items.First().Perm);
        }

        [Test]
        public void GetAccountAdministrativePermissions_EmptyResult()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountAdministrativePermissions.xml"));
            var request = new GetAccountAdministrativePermissions
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountAdministrativePermissions_EmptyResult.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.NotNull(response.DomainsPermissions);
            Assert.False(response.DomainsPermissions.Items.Any());
            Assert.NotNull(response.GlobalPermissions);
            Assert.False(response.GlobalPermissions.Items.Any());
        }

        [Test]
        public void GetAccountAPIConsole()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountAPIConsole.xml"));
            var request = new GetAccountAPIConsole
            {
                SessionId = "sid",
                AccountEmail = "test@testing.co.uk",
                Filter = new TPropertyListFilter
                {
                    Mask = "u",
                    Groups = new TPropertyStringList { Val = new List<string> { "User" } },
                    Clear = true
                },
                Comments = true
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountAPIConsole.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(154, response.OverallCount);
            Assert.AreEqual(10, response.Items.Count);

            Assert.AreEqual("u_abqstatus", response.Items.First().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.First().PropertyVal.GetType());
            Assert.True(String.IsNullOrEmpty(((TPropertyString)response.Items.First().PropertyVal).Val));
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);
            Assert.AreEqual("One char only, status of ABQ", response.Items.First().PropertyComment);
            Assert.AreEqual("User", response.Items.First().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.String, response.Items.First().PropertyValueType);

            Assert.AreEqual("u_activesynceditable", response.Items.Last().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.Last().PropertyVal.GetType());
            Assert.AreEqual("1", ((TPropertyString)response.Items.Last().PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
            Assert.AreEqual("Read only variable to check if the user has ActiveSync Editable", response.Items.Last().PropertyComment);
            Assert.AreEqual("User", response.Items.Last().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.Bool, response.Items.Last().PropertyValueType);
        }

        [Test]
        public void GetAccountAPIConsole_NoFilter()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountAPIConsole_NoFilter.xml"));
            var request = new GetAccountAPIConsole
            {
                SessionId = "sid",
                AccountEmail = "test@testing.co.uk",
                Comments = true
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountAPIConsole.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(154, response.OverallCount);
            Assert.AreEqual(10, response.Items.Count);

            Assert.AreEqual("u_abqstatus", response.Items.First().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.First().PropertyVal.GetType());
            Assert.True(String.IsNullOrEmpty(((TPropertyString)response.Items.First().PropertyVal).Val));
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);
            Assert.AreEqual("One char only, status of ABQ", response.Items.First().PropertyComment);
            Assert.AreEqual("User", response.Items.First().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.String, response.Items.First().PropertyValueType);

            Assert.AreEqual("u_activesynceditable", response.Items.Last().APIProperty.PropName);
            Assert.AreEqual(typeof(TPropertyString), response.Items.Last().PropertyVal.GetType());
            Assert.AreEqual("1", ((TPropertyString)response.Items.Last().PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
            Assert.AreEqual("Read only variable to check if the user has ActiveSync Editable", response.Items.Last().PropertyComment);
            Assert.AreEqual("User", response.Items.Last().PropertyGroup);
            Assert.AreEqual(TPropertyValueType.Bool, response.Items.Last().PropertyValueType);
        }

        [Test]
        public void GetAccountFolderList()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountFolderList.xml"));
            var request = new GetAccountFolderList
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                OnlyDefault = false
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountFolderList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual("test@testing.com", response.Name);
            Assert.AreEqual("2", response.ID);
            Assert.AreEqual("X", response.FolderType);
            Assert.True(String.IsNullOrEmpty(response.DefaultType));
            Assert.NotNull(response.SubFolders);
            Assert.AreEqual(7, response.SubFolders.Items.Count);

            Assert.AreEqual("Inbox", response.SubFolders.Items.Last().Name);
            Assert.AreEqual("0SU5CT1g=", response.SubFolders.Items.Last().ID);
            Assert.AreEqual("M", response.SubFolders.Items.Last().FolderType);
            Assert.AreEqual("I", response.SubFolders.Items.Last().DefaultType);
            Assert.NotNull(response.SubFolders.Items.Last().SubFolders);
            Assert.AreEqual(0, response.SubFolders.Items.Last().SubFolders.Items.Count);
        }

        [Test]
        public void GetAccountFolderPermissions()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountFolderPermissions.xml"));
            var request = new GetAccountFolderPermissions
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                FolderId = "2"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountFolderPermissions.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.False(response.IsInherited);
            Assert.NotNull(response.Items);
            Assert.AreEqual(1, response.Items.Count);
            Assert.AreEqual("test@testing.com", response.Items.First().Account);
            Assert.AreEqual("permissions", response.Items.First().Permissions);
        }

        [Test]
        public void GetAccountProperties()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountProperties.xml"));
            var request = new GetAccountProperties
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                AccountPropertyList = new TAccountPropertyList
                {
                    Items = new List<TAPIProperty>
                    {
                        new TAPIProperty{PropName = "u_name"},
                        new TAPIProperty{PropName = "u_alias"},
                        new TAPIProperty{PropName = "u_type"}
                    }
                }
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(3, response.Items.Count);

            var name = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "u_name");
            Assert.NotNull(name);
            Assert.AreEqual(typeof(TPropertyString), name.PropertyVal.GetType());
            Assert.AreEqual("Test", ((TPropertyString)name.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.First().PropertyRight);

            var alias = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "u_alias");
            Assert.NotNull(alias);
            Assert.AreEqual(typeof(TPropertyString), alias.PropertyVal.GetType());
            Assert.AreEqual("test", ((TPropertyString)alias.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);

            var type = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "u_type");
            Assert.NotNull(type);
            Assert.AreEqual(typeof(TPropertyString), type.PropertyVal.GetType());
            Assert.AreEqual("0", ((TPropertyString)type.PropertyVal).Val);
            Assert.AreEqual(TPermission.ReadWrite, response.Items.Last().PropertyRight);
        }

        [Test]
        public void GetAccountProperties_PropertySet()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountProperties_PropertySet.xml"));
            var request = new GetAccountProperties
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                AccountPropertySet = TAccountPropertySet.Info
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountProperties_PropertySet.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(5, response.Items.Count);

            var a_Name = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "A_Name");
            Assert.NotNull(a_Name);
            Assert.AreEqual(typeof(TAccountName), a_Name.PropertyVal.GetType());
            Assert.AreEqual("Test", ((TAccountName)a_Name.PropertyVal).Name);
            Assert.True(String.IsNullOrEmpty(((TAccountName)a_Name.PropertyVal).Surname));
            Assert.AreEqual(TPermission.ReadWrite, a_Name.PropertyRight);

            var a_Quota = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "A_Quota");
            Assert.NotNull(a_Quota);
            Assert.AreEqual(typeof(TAccountQuota), a_Quota.PropertyVal.GetType());
            Assert.AreEqual(934, ((TAccountQuota)a_Quota.PropertyVal).MailboxSize);
            Assert.AreEqual(0, ((TAccountQuota)a_Quota.PropertyVal).MailboxQuota);
            Assert.AreEqual(TPermission.ReadWrite, a_Quota.PropertyRight);

            var a_Image = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "A_Image");
            Assert.NotNull(a_Image);
            Assert.AreEqual(typeof(TPropertyNoValue), a_Image.PropertyVal.GetType());
            Assert.AreEqual(TPermission.ReadWrite, a_Image.PropertyRight);

            var a_AliasList = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "A_AliasList");
            Assert.NotNull(a_AliasList);
            Assert.AreEqual(typeof(TPropertyStringList), a_AliasList.PropertyVal.GetType());
            Assert.AreEqual(1, ((TPropertyStringList)a_AliasList.PropertyVal).Val.Count);
            Assert.AreEqual("test", ((TPropertyStringList)a_AliasList.PropertyVal).Val.First());
            Assert.AreEqual(TPermission.ReadWrite, a_AliasList.PropertyRight);

            var a_State = response.Items.FirstOrDefault(x => x.APIProperty.PropName == "A_State");
            Assert.NotNull(a_State);
            Assert.AreEqual(typeof(TAccountState), a_State.PropertyVal.GetType());
            Assert.AreEqual(TUserState.Empty, ((TAccountState)a_State.PropertyVal).State);
            Assert.AreEqual(TPermission.ReadWrite, a_State.PropertyRight);
        }

        [Test]
        public void GetAccountsInfoList()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountsInfoList.xml"));
            var request = new GetAccountsInfoList
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
                Filter = new TAccountListFilter
                {
                    NameMask = "test",
                    TypeMask = AccountType.User
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountsInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(2, response.OverallCount);
            Assert.AreEqual(2, response.Items.Count);

            Assert.AreEqual("Public Folders", response.Items.First().Name);
            Assert.AreEqual("public-folders@testing.co.uk", response.Items.First().Email);
            Assert.AreEqual(AccountType.Group, response.Items.First().AccountType);
            Assert.AreEqual(TAdminType.User, response.Items.First().AdminType);
            Assert.NotNull(response.Items.First().Quota);
            Assert.AreEqual(0, response.Items.First().Quota.MailboxSize);
            Assert.AreEqual(0, response.Items.First().Quota.MailboxQuota);

            Assert.AreEqual("Test", response.Items.Last().Name);
            Assert.AreEqual("test@testing.co.uk", response.Items.Last().Email);
            Assert.AreEqual(AccountType.User, response.Items.Last().AccountType);
            Assert.AreEqual(TAdminType.Admin, response.Items.Last().AdminType);
            Assert.NotNull(response.Items.Last().Quota);
            Assert.AreEqual(934, response.Items.Last().Quota.MailboxSize);
            Assert.AreEqual(0, response.Items.Last().Quota.MailboxQuota);
        }

        [Test]
        public void GetAccountsInfoList_NoFilter()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "GetAccountsInfoList_NoFilter.xml"));
            var request = new GetAccountsInfoList
            {
                SessionId = "sid",
                DomainStr = "testing.co.uk",
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "GetAccountsInfoList.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.AreEqual(0, response.Offset);
            Assert.AreEqual(2, response.OverallCount);
            Assert.AreEqual(2, response.Items.Count);

            Assert.AreEqual("Public Folders", response.Items.First().Name);
            Assert.AreEqual("public-folders@testing.co.uk", response.Items.First().Email);
            Assert.AreEqual(AccountType.Group, response.Items.First().AccountType);
            Assert.AreEqual(TAdminType.User, response.Items.First().AdminType);
            Assert.NotNull(response.Items.First().Quota);
            Assert.AreEqual(0, response.Items.First().Quota.MailboxSize);
            Assert.AreEqual(0, response.Items.First().Quota.MailboxQuota);

            Assert.AreEqual("Test", response.Items.Last().Name);
            Assert.AreEqual("test@testing.co.uk", response.Items.Last().Email);
            Assert.AreEqual(AccountType.User, response.Items.Last().AccountType);
            Assert.AreEqual(TAdminType.Admin, response.Items.Last().AdminType);
            Assert.NotNull(response.Items.Last().Quota);
            Assert.AreEqual(934, response.Items.Last().Quota.MailboxSize);
            Assert.AreEqual(0, response.Items.Last().Quota.MailboxQuota);
        }

        [Test]
        public void InheritAccountFolderPermissions()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "InheritAccountFolderPermissions.xml"));
            var request = new InheritAccountFolderPermissions
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                FolderId = "2"
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "InheritAccountFolderPermissions.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SendAccountActivationKey()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SendAccountActivationKey.xml"));
            var request = new SendAccountActivationKey
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                KeyType = TActivationKeyType.DesktopClient,
                Count = "10",
                Description = "key description"
            };
            var requestXml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, requestXml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SendAccountActivationKey.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetAccountFolderPermissions()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetAccountFolderPermissions.xml"));
            var request = new SetAccountFolderPermissions
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                FolderId = "2",
                Permissions = new TFolderPermissions
                {
                    Items = new List<TFolderPermissionsItem>
                    {
                        new TFolderPermissionsItem{ Account = "test@testing.com", Permissions = "Permissions" }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetAccountFolderPermissions.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetAccountPassword()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetAccountPassword.xml"));
            var request = new SetAccountPassword
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                AuthType = TAuthType.Plain,
                Password = "test",
                Digest = "digest",
                IgnorePolicy = false
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetAccountPassword.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
            Assert.True(response.Success);
        }

        [Test]
        public void SetAccountProperties()
        {
            //Test request
            string expected = File.ReadAllText(Path.Combine(_requestsTestDataPath, "SetAccountProperties.xml"));
            var request = new SetAccountProperties
            {
                SessionId = "sid",
                AccountEmail = "test@testing.com",
                PropertyValueList = new TPropertyValueList
                {
                    Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "Responder"},
                            PropertyVal = new TAccountResponder
                            {
                                NoRespond = new TPropertyStringList{ Val = new List<string>{ "no@respond.com" }},
                                ResponderMessage = new TAccountResponderMessage
                                {
                                    From = "from@testing.com",
                                    Subject = "Testing",
                                    Text = "Test Test"
                                },
                                ResponderType = TResponder.None,
                                RespondOnlyIfToMe = false
                            },
                            PropertyRight = TPermission.ReadWrite
                        },
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "AccountName"},
                            PropertyVal = new TAccountName
                            {
                                Name = "This",
                                Surname = "Test"
                            },
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                }
            };
            var xml = request.ToXml().InnerXmlFormatted();
            Assert.AreEqual(expected, xml);

            //Test response
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(Path.Combine(_responsesTestDataPath, "SetAccountProperties.xml")));
            var response = request.FromHttpRequestResult(new HttpRequestResult { Response = doc.InnerXml });

            Assert.AreEqual("result", response.Type);
        }

    }
}
