using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class MailingList_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("MailingList_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(61, propertyValueListResponse.Items.Count);

            var account = new MailingList(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.MailingList, account.U_Type.Value);
            Assert.AreEqual("all-users", account.U_Alias);
            Assert.AreEqual("all-users@testing.co.uk", account.U_AliasList);
            Assert.AreEqual("All Users", account.U_Name);
            Assert.AreEqual("eJxjZGBg4HLMyVEILU4tKrZmGGGAEURwJubk6JaC/D/QzhkYIFSSWlziACIy89L1kvP1SrMH2kn0BYwyKJ6PgacHvZKKkhGRJxgZR4Q3cQPGgXbAKBgFIKCKWRjXZOal5Y/k8pmugIlRKAQY1Aq+iZk5wPBW8MksLqkZEHcMgKWjAA0AAAkmLuw=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual(@"testing.co.uk\all-users.txt", account.M_ListFile);
            Assert.True(account.M_SeparateTo.HasValue);
            Assert.True(account.M_SeparateTo.Value);
            Assert.True(account.M_MaxListSize.HasValue);
            Assert.AreEqual(0, account.M_MaxListSize);
            Assert.True(account.M_SetSender.HasValue);
            Assert.AreEqual(MailingListSetSender.SetReplyTo_ToSender, account.M_SetSender.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new MailingList().PropertyNamesList();

            Assert.AreEqual(61, propertyNames.Count);
        }
    }
}
