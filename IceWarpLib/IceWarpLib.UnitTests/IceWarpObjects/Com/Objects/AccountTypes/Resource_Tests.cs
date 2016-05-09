using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class Resource_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Resource_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(15, propertyValueListResponse.Items.Count);

            var account = new Resource(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.Resource, account.U_Type.Value);
            Assert.AreEqual("test-resource", account.U_Alias);
            Assert.AreEqual("test-resource@testing.co.uk", account.U_AliasList);
            Assert.AreEqual("Test Resource", account.U_Name);
            Assert.AreEqual("eJzjYGBk4AtJLS5RCEotzi8tSk61ZhhBgBFE8JYA/a9bBPX/QDtpFAwAkAclgcy8dL3kfL3S7BiUBKFXUlEy0O4bBaNgFIyCUTAKRgEdAQB0YRco", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("[testing.co.uk]\r\ninfo@testing.co.uk\r\ntest@testing.co.uk\r\n", account.S_OrganizersFile_Contents);
            Assert.True(account.S_Unavailable.HasValue);
            Assert.False(account.S_Unavailable.Value);
            Assert.True(account.S_Type.HasValue);
            Assert.AreEqual(ResourceType.Room, account.S_Type.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Resource().PropertyNamesList();

            Assert.AreEqual(15, propertyNames.Count);
        }
    }
}
