using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class User_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("User_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(153, propertyValueListResponse.Items.Count);

            var account = new User(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.User, account.U_Type.Value);
            Assert.AreEqual("test", account.U_Alias);
            Assert.AreEqual("test@testing.co.uk", account.U_AliasList);
            Assert.AreEqual("Test", account.U_Name);
            Assert.AreEqual("eJxjYGBkYA1JLS6xZhiJgBGEWUqA/h9olwwgGJT+Z6SDHSwQWzgDEouLy/OLUgzpYOcgBMKg+M/MS9dLztcrzY4B8WIG2k30BPRIaqNgFIyCUTAKhhYAAIQKEJc=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("test", account.U_EmailAlias);
            Assert.True(account.U_Admin.HasValue);
            Assert.True(account.U_Admin.Value);
            Assert.True(account.U_MaxBoxSize.HasValue);
            Assert.AreEqual(0, account.U_MaxBoxSize);
            Assert.True(account.U_AccountValidTill_Date.HasValue);
            Assert.AreEqual(1899, account.U_AccountValidTill_Date.Value.Year);
            Assert.AreEqual(12, account.U_AccountValidTill_Date.Value.Month);
            Assert.AreEqual(30, account.U_AccountValidTill_Date.Value.Day);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new User().PropertyNamesList();

            Assert.AreEqual(153, propertyNames.Count);
        }
    }
}
