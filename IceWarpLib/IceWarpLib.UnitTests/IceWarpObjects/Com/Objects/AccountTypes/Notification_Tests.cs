using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class Notification_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Notification_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(33, propertyValueListResponse.Items.Count);

            var account = new Notification(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.Notification, account.U_Type.Value);
            Assert.AreEqual("notification-test", account.U_Alias);
            Assert.AreEqual("notification-test@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjZmBgYLRmGKmAEUQI5uWXZKZlJieWZObn6ZakFpcMtLPoC4RAXnYAEZl56XrJ+Xql2QPtJLoCUCJoANEgAEkSo2BEA6bRRDAKRsEoGAUjHAAAfNMO7g==", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("test@testing.co.uk", account.N_NotifyTo);
            Assert.True(account.N_IMNotification.HasValue);
            Assert.False(account.N_IMNotification.Value);
            Assert.True(account.N_Count.HasValue);
            Assert.AreEqual(1, account.N_Count);
            Assert.True(account.N_FilterType.HasValue);
            Assert.AreEqual(NotificationFilter.All, account.N_FilterType.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Notification().PropertyNamesList();

            Assert.AreEqual(33, propertyNames.Count);
        }
    }
}
