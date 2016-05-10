using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.UnitTests.IceWarpObjects.Com.Objects;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Helpers
{
    public class TPropertyValHelperTests : BaseTest
    {
        public void GetConcreteAccountType_User()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("User_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(153, propertyValueListResponse.Items.Count);

            var account = TPropertyValHelper.GetConcreteAccountType(propertyValueListResponse.Items);

            Assert.AreEqual(typeof(User), account.GetType());

            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.User, account.U_Type.Value);
            Assert.AreEqual("test", account.U_Alias);
            Assert.AreEqual("test@testing.co.uk", account.U_AliasList);
            Assert.AreEqual("Test", account.U_Name);
            Assert.AreEqual("eJxjYGBkYA1JLS6xZhiJgBGEWUqA/h9olwwgGJT+Z6SDHSwQWzgDEouLy/OLUgzpYOcgBMKg+M/MS9dLztcrzY4B8WIG2k30BPRIaqNgFIyCUTAKhhYAAIQKEJc=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            var specificAccountType = (User) account;
            Assert.AreEqual("test", specificAccountType.U_EmailAlias);
            Assert.True(specificAccountType.U_Admin.HasValue);
            Assert.True(specificAccountType.U_Admin.Value);
            Assert.True(specificAccountType.U_MaxBoxSize.HasValue);
            Assert.AreEqual(0, specificAccountType.U_MaxBoxSize);
            Assert.True(specificAccountType.U_AccountValidTill_Date.HasValue);
            Assert.AreEqual(1899, specificAccountType.U_AccountValidTill_Date.Value.Year);
            Assert.AreEqual(12, specificAccountType.U_AccountValidTill_Date.Value.Month);
            Assert.AreEqual(30, specificAccountType.U_AccountValidTill_Date.Value.Day);
        }

        public void GetConcreteAccountType_StaticRoute()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("StaticRoute_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(18, propertyValueListResponse.Items.Count);

            var account = TPropertyValHelper.GetConcreteAccountType(propertyValueListResponse.Items);

            Assert.AreEqual(typeof(StaticRoute), account.GetType());

            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.StaticRoute, account.U_Type.Value);
            Assert.AreEqual("static-route", account.U_Alias);
            Assert.AreEqual("static-route@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjYWBgYLRmGKmAEUTwFJcklmQm6xbll5akDrSLBgAwDrQDRsHAAqaBdsBAA0buktTiksy8dL3k/NyBdswoGAWjYBSMgkEAAOJ3Caw=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            var specificAccountType = (StaticRoute)account;
            Assert.AreEqual("testing.com", specificAccountType.R_SaveTo);
            Assert.True(specificAccountType.R_ExternalDomain.HasValue);
            Assert.True(specificAccountType.R_ExternalDomain.Value);
            Assert.True(specificAccountType.R_ExternalFilter.HasValue);
            Assert.AreEqual(ExternalFilter.All, specificAccountType.R_ExternalFilter.Value);
        }
    }
}
