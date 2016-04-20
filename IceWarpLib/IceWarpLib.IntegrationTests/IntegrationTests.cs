using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpObjects.Rpc.Enums;
using IceWarpRpc;
using IceWarpRpc.Requests.Session;
using NUnit.Framework;

namespace IceWarpLib.IntegrationTests
{
    [TestFixture]
    public class IntegrationTests
    {
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
            var url = ConfigurationManager.AppSettings["IceWarpUrl"]; ;
            var api = new IceWarpApi();
            var authenticate = new Authenticate
            {
                AuthType = TAuthType.Plain,
                Digest = "",
                Email = ConfigurationManager.AppSettings["AdminEmail"],
                Password = ConfigurationManager.AppSettings["AdminPassword"],
                PersistantLogin = false
            };
            var authResult = api.Execute(url, authenticate);

            Assert.NotNull(authResult);
            Assert.NotNull(authResult.HttpRequestResult);
            Assert.True(authResult.HttpRequestResult.Success);

            var sessionInfo = new GetSessionInfo
            {
                SessionId = authResult.SessionId
            };
            var sessionInfoResult = api.Execute(url, sessionInfo);

            Assert.NotNull(sessionInfoResult);
            Assert.NotNull(sessionInfoResult.HttpRequestResult);
            Assert.True(sessionInfoResult.HttpRequestResult.Success);

            var logout = new Logout
            {
                SessionId = authResult.SessionId
            };
            var logoutResult = api.Execute(url, logout);

            Assert.NotNull(logoutResult);
            Assert.NotNull(logoutResult.HttpRequestResult);
            Assert.True(logoutResult.HttpRequestResult.Success);
        }
    }
}
