using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class StaticRoute_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("StaticRoute_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(18, propertyValueListResponse.Items.Count);

            var account = new StaticRoute(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.StaticRoute, account.U_Type.Value);
            Assert.AreEqual("static-route", account.U_Alias);
            Assert.AreEqual("static-route@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjYWBgYLRmGKmAEUTwFJcklmQm6xbll5akDrSLBgAwDrQDRsHAAqaBdsBAA0buktTiksy8dL3k/NyBdswoGAWjYBSMgkEAAOJ3Caw=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("testing.com", account.R_SaveTo);
            Assert.True(account.R_ExternalDomain.HasValue);
            Assert.True(account.R_ExternalDomain.Value);
            Assert.True(account.R_ExternalFilter.HasValue);
            Assert.AreEqual(ExternalFilter.All, account.R_ExternalFilter.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new StaticRoute().PropertyNamesList();

            Assert.AreEqual(18, propertyNames.Count);
        }
    }
}
