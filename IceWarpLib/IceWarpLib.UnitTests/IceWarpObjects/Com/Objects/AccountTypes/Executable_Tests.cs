using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class Executable_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Executable_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(19, propertyValueListResponse.Items.Count);

            var account = new Executable(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.Executable, account.U_Type.Value);
            Assert.AreEqual("executable-test", account.U_Alias);
            Assert.AreEqual("executable-test@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjYmBgYLRmGKmAEUTwp1akJpeWJCblpOqWpBaXDLSjRsEoGAX0A8wcBYnFxeX5RSkD7ZJRMApGwSgYBYMFAAC0yAnc", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("password", account.E_ExecPass);
            Assert.True(account.E_BlackWhiteFilter.HasValue);
            Assert.False(account.E_BlackWhiteFilter.Value);
            Assert.True(account.E_ExecType.HasValue);
            Assert.AreEqual(ExecutableType.Url, account.E_ExecType.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Executable().PropertyNamesList();

            Assert.AreEqual(19, propertyNames.Count);
        }
    }
}
