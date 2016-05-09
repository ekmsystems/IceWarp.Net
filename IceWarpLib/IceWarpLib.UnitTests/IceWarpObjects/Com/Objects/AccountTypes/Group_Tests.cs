using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class Group_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Group_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(32, propertyValueListResponse.Items.Count);

            var account = new Group(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.Group, account.U_Type.Value);
            Assert.AreEqual("public-folders", account.U_Alias);
            Assert.AreEqual("public-folders@testing.co.uk", account.U_AliasList);
            Assert.AreEqual("Public Folders", account.U_Name);
            Assert.AreEqual("eJxjZ2Bg4AsoTcrJTFZwy89JSS0qZhhBgBFE8BWA/a+bNvL8PwrAQKEktbgkMy9dLzlfrzQ7BjU96JVUlAy0A0fBKBgFo2AUjETAPtAOGLkAAOxPF8Y=", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual(@"testing.co.uk\public-folders.txt", account.G_ListFile);
            Assert.True(account.G_GroupwareShared.HasValue);
            Assert.True(account.G_GroupwareShared.Value);
            Assert.True(account.G_ListBatch.HasValue);
            Assert.AreEqual(0, account.G_ListBatch);
            Assert.True(account.G_Moderated.HasValue);
            Assert.AreEqual(Moderation.None, account.G_Moderated.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Group().PropertyNamesList();

            Assert.AreEqual(32, propertyNames.Count);
        }
    }
}
