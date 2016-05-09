using System;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Com.Objects.AccountTypes
{
    public class Catalog_Tests : BaseTest
    {
        [Test]
        public void Constructor()
        {
            var propertyValueListResponse = BuildTPropertyValueListResponseFromFile("Catalog_TPropertyValueListResponse.xml");

            Assert.NotNull(propertyValueListResponse);
            Assert.NotNull(propertyValueListResponse.HttpRequestResult);
            Assert.NotNull(propertyValueListResponse.Items);
            Assert.AreEqual(21, propertyValueListResponse.Items.Count);

            var account = new Catalog(propertyValueListResponse.Items);
            //shared properties
            Assert.True(account.U_Type.HasValue);
            Assert.AreEqual(AccountType.Catalog, account.U_Type.Value);
            Assert.AreEqual("catalog-test", account.U_Alias);
            Assert.AreEqual("catalog-test@testing.co.uk", account.U_AliasList);
            Assert.True(String.IsNullOrEmpty(account.U_Name));
            Assert.AreEqual("eJxjZWBgYLRmGKmAEUTwJCeWJObkp+uWpBaXDLSLRgHdARMjIyNHQWJxcXl+UcoAuYFxgOwdBaNgFIyCUTAKRgEmAADn0AiY", account.U_Backup);
            Assert.False(account.U_GW_DailyAgenda.HasValue);

            //account type specific properties
            Assert.AreEqual("password", account.T_CatalogPass);
            Assert.True(account.T_CatalogSubject.HasValue);
            Assert.True(account.T_CatalogSubject.Value);
            Assert.True(account.T_CatalogSender.HasValue);
            Assert.AreEqual(Originator.Owner, account.T_CatalogSender.Value);
        }

        [Test]
        public void PropertyNames()
        {
            var propertyNames = new Catalog().PropertyNamesList();

            Assert.AreEqual(21, propertyNames.Count);
        }
    }
}
