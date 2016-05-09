using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects
{
    public class Domain_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Domain_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(88, propertyValueListResponse.Items.Count);

            var domain = new Domain(propertyValueListResponse.Items);

            Assert.True(domain.D_Type.HasValue);
            Assert.AreEqual(DomainType.Standard, domain.D_Type.Value);
            Assert.AreEqual("postmaster;admin;administrator;supervisor;hostmaster;webmaster;abuse", domain.D_PostMaster);
            Assert.True(domain.D_DisableLogin.HasValue);
            Assert.False(domain.D_DisableLogin.Value);
            Assert.True(domain.D_DiskQuota.HasValue);
            Assert.AreEqual(0, domain.D_DiskQuota);
            Assert.True(domain.D_ExpiresOn_Date.HasValue);
            Assert.AreEqual(1899, domain.D_ExpiresOn_Date.Value.Year);
            Assert.AreEqual(12, domain.D_ExpiresOn_Date.Value.Month);
            Assert.AreEqual(30, domain.D_ExpiresOn_Date.Value.Day);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Domain().PropertyNamesList();

            Assert.AreEqual(88, propertyNames.Count);
        }
    }
}
