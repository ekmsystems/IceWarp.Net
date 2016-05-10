using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using IceWarpLib.Objects.Com.Objects.Configuration;
using IceWarpLib.Objects.Com.Objects.Configuration.Advanced;
using IceWarpLib.Objects.Com.Objects.Configuration.Global;
using IceWarpLib.Objects.Com.Objects.Configuration.Tools;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Classes.Domain;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Classes.Server;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Requests.Account;
using IceWarpLib.Rpc.Requests.Domain;
using IceWarpLib.Rpc.Requests.Server;
using IceWarpLib.Rpc.Requests.Session;
using IceWarpLib.Rpc.Responses;
using NUnit.Framework;

namespace IceWarpLib.IntegrationTests
{
    [TestFixture]
    public class IntegrationTests
    {
        private string _url = ConfigurationManager.AppSettings["IceWarpUrl"];
        private string _adminEmail = ConfigurationManager.AppSettings["AdminEmail"];
        private string _adminPassword = ConfigurationManager.AppSettings["AdminPassword"];

        [TestFixtureSetUp]
        public void FixtureSetup() { }

        [SetUp]
        public void TestSetup() { }

        [TearDown]
        public void TestTearDown() { }

        [TestFixtureTearDown]
        public void FixtureTearDown() { }

        [Test]
        public void Connect()
        {
            var api = new IceWarpRpcApi();
            var authResult = Authenticate(api);

            var sessionInfo = new GetSessionInfo
            {
                SessionId = authResult.SessionId
            };
            var sessionInfoResult = api.Execute(_url, sessionInfo);

            Assert.NotNull(sessionInfoResult);
            Assert.NotNull(sessionInfoResult.HttpRequestResult);
            Assert.True(sessionInfoResult.HttpRequestResult.Success);

            LogOut(api, authResult.SessionId);
        }

        [Test]
        public void DeleteDomain()
        {
            var api = new IceWarpRpcApi();
            var authResult = Authenticate(api);

            var domainToDelete = "deletedomain.com";
            var deleteDomainAdminEmail = "test@testing.com";

            //Check domain does not exist
            var getDomainProperties = new GetDomainProperties
            {
                SessionId = authResult.SessionId,
                DomainStr = domainToDelete,
                DomainPropertyList = new TDomainPropertyList
                {
                    Items = new List<TAPIProperty>
                    {

                        new TAPIProperty {PropName = "D_AdminEmail"}
                    }
                }
            };
            try
            {
                var domainCheckResult = api.Execute(_url, getDomainProperties);
            }
            catch (IceWarpErrorException e)
            {
                //Create domain
                var createDomain = new CreateDomain
                {
                    SessionId = authResult.SessionId,
                    DomainStr = domainToDelete,
                    DomainProperties = new TPropertyValueList
                    {
                        Items = new List<TPropertyValue>
                    {
                        new TPropertyValue
                        {
                            APIProperty = new TAPIProperty{ PropName = "D_AdminEmail"},
                            PropertyVal = new TPropertyString{ Val = deleteDomainAdminEmail},
                            PropertyRight = TPermission.ReadWrite
                        }
                    }
                    }
                };
                var createDomainResult = api.Execute(_url, createDomain);
                Assert.True(createDomainResult.Success);

                //Check can get properties for new domain
                var getDomainPropertiesResult = api.Execute(_url, getDomainProperties);
                Assert.AreEqual(1, getDomainPropertiesResult.Items.Count);
                Assert.AreEqual("tpropertystring", getDomainPropertiesResult.Items.First().PropertyVal.ClassName);
                Assert.AreEqual(deleteDomainAdminEmail, ((TPropertyString)getDomainPropertiesResult.Items.First().PropertyVal).Val);
            }

            //Delete domain
            var deleteDomain = new DeleteDomain
            {
                SessionId = authResult.SessionId,
                DomainStr = domainToDelete
            };
            var deleteDomainResult = api.Execute(_url, deleteDomain);
            Assert.True(deleteDomainResult.Success);

            //Check domain does not exist
            var exception = Assert.Throws<IceWarpErrorException>(() => api.Execute(_url, getDomainProperties));
            Assert.AreEqual("domain_invalid", exception.IceWarpError);

            LogOut(api, authResult.SessionId);
        }

        [Test]
        public void GetServerProperties()
        {
            var api = new IceWarpRpcApi();
            var authResult = Authenticate(api);

            var propertyNames = ClassHelper.PublicProperites(typeof(AccountsGlobalSettings)).Select(x => x.Name).ToList();
            Assert.AreEqual(21, propertyNames.Count);

            var request = new GetServerProperties
            {
                SessionId = authResult.SessionId,
                ServerPropertyList = new TServerPropertyList
                {
                    Items = propertyNames.Select(x => new TAPIProperty {PropName = x}).ToList()
                }
            };
            var getPropertiesResult = api.Execute(_url, request);

            Assert.NotNull(getPropertiesResult);
            Assert.NotNull(getPropertiesResult.HttpRequestResult);
            Assert.True(getPropertiesResult.HttpRequestResult.Success);
            Assert.NotNull(getPropertiesResult.Items);

            var settings = new AccountsGlobalSettings(getPropertiesResult.Items);
            Assert.AreEqual(21, propertyNames.Count);
        }

        [Test]
        public void GetUserAccountProperties()
        {
            var api = new IceWarpRpcApi();
            var authResult = Authenticate(api);

            var propertyNames = ClassHelper.Properites(typeof(User), BindingFlags.Instance | BindingFlags.Public).Select(x => x.Name).ToList();
            Assert.AreEqual(153, propertyNames.Count);

            var request = new GetAccountProperties
            {
                SessionId = authResult.SessionId,
                AccountEmail = "test@testing.co.uk",
                AccountPropertyList = new TAccountPropertyList
                {
                    Items = propertyNames.Select(x => new TAPIProperty { PropName = x }).ToList()
                }
            };
            var getPropertiesResult = api.Execute(_url, request);

            Assert.NotNull(getPropertiesResult);
            Assert.NotNull(getPropertiesResult.HttpRequestResult);
            Assert.True(getPropertiesResult.HttpRequestResult.Success);
            Assert.NotNull(getPropertiesResult.Items);

            var user = new User(getPropertiesResult.Items);
            Assert.True(user.U_Type.HasValue);
            Assert.AreEqual(AccountType.User, user.U_Type.Value);
            Assert.AreEqual("test", user.U_EmailAlias);
            Assert.True(user.U_Admin.HasValue);
            Assert.True(user.U_Admin.Value);
            Assert.True(user.U_MaxBoxSize.HasValue);
            Assert.AreEqual(0, user.U_MaxBoxSize);
            Assert.True(user.U_AccountValidTill_Date.HasValue);
            Assert.AreEqual(1899, user.U_AccountValidTill_Date.Value.Year);
            Assert.AreEqual(12, user.U_AccountValidTill_Date.Value.Month);
            Assert.AreEqual(30, user.U_AccountValidTill_Date.Value.Day);

            LogOut(api, authResult.SessionId);
        }

        [Test]
        public void GetServerProperties_MigrationToolSettings()
        {
            var api = new IceWarpRpcApi();
            var authResult = Authenticate(api);

            var propertyNames = ClassHelper.PublicGetProperites(typeof(MigrationToolSettings));
            Assert.AreEqual(21, propertyNames.Count);

            var request = new GetServerProperties
            {
                SessionId = authResult.SessionId,
                ServerPropertyList = new TServerPropertyList
                {
                    Items = propertyNames.Select(x => new TAPIProperty { PropName = x.Name }).ToList()
                }
            };
            var getPropertiesResult = api.Execute(_url, request);

            Assert.NotNull(getPropertiesResult);
            Assert.NotNull(getPropertiesResult.HttpRequestResult);
            Assert.True(getPropertiesResult.HttpRequestResult.Success);
            Assert.NotNull(getPropertiesResult.Items);

            var settings = new MigrationToolSettings(getPropertiesResult.Items);
            
            Assert.AreEqual(21, propertyNames.Count);
        }

        private SuccessResponse Authenticate(IceWarpRpcApi api)
        {
            var authenticate = new Authenticate
            {
                AuthType = TAuthType.Plain,
                Digest = "",
                Email = _adminEmail,
                Password = _adminPassword,
                PersistentLogin = false
            };
            var authResult = api.Execute(_url, authenticate);

            Assert.NotNull(authResult);
            Assert.NotNull(authResult.HttpRequestResult);
            Assert.True(authResult.HttpRequestResult.Success);

            return authResult;
        }

        private void LogOut(IceWarpRpcApi api, string sessionId)
        {
            var logout = new Logout
            {
                SessionId = sessionId
            };
            var logoutResult = api.Execute(_url, logout);

            Assert.NotNull(logoutResult);
            Assert.NotNull(logoutResult.HttpRequestResult);
            Assert.True(logoutResult.HttpRequestResult.Success);
        }
    }
}
