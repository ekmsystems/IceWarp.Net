using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule
{
    public class TRuleEditHeaderItem_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <editheadertype>0</editheadertype>
    <header>Header</header>
    <hasregex>1</hasregex>
    <regex>Regex</regex>
    <value>Value</value>
</custom>".TrimStart();

        [Test]
        public void TRuleEditHeaderItem()
        {
            var testClass = new TRuleEditHeaderItem
            {
                EditHeaderType = TRuleEditHeaderType.AddEdit,
                Header = "Header",
                HasRegex = true,
                Regex = "Regex",
                Value = "Value"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleEditHeaderItem_BuildXmlElement()
        {
            var testClass = new TRuleEditHeaderItem(GetXmlNode(_xml));

            Assert.AreEqual(TRuleEditHeaderType.AddEdit, testClass.EditHeaderType);
            Assert.AreEqual("Header", testClass.Header);
            Assert.True(testClass.HasRegex);
            Assert.AreEqual("Regex", testClass.Regex);
            Assert.AreEqual("Value", testClass.Value);
        }
    }
}
