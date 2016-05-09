using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class ListServer_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("ListServer_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(35, propertyValueListResponse.Items.Count);

            var account = new ListServer(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.ListServer, account.U_Type.Value);
            Assert.AreEqual("listserver", account.U_Alias);
            Assert.AreEqual("listserver@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjY2BgYLRmGKmAEURw5WQWlxSnFpWlFg20ewYECJWkFpc4gIjMvHS95Hy90uyBdhKdgQyK52MQ6UGvpKJkoB1HB8A40A4YcDAaAqNgFIyCwQAYwYAJzmcbQLeMdAAAZJkXNA==", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual(@"testing.co.uk\listserver.txt", account.L_ListFile);
            Assert.True(account.L_ListSubject.HasValue);
            Assert.True(account.L_ListSubject.Value);
            Assert.True(account.L_SendAllLists.HasValue);
            Assert.AreEqual(ListServerMembersSource.AllDomainMailingLists, account.L_SendAllLists.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new ListServer().PropertyNamesList();

            Assert.AreEqual(35, propertyNames.Count);
        }
    }
}
