using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule
{
    public class TRuleEditHeaderList_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <item>
        <editheadertype>0</editheadertype>
        <header>Header</header>
        <hasregex>1</hasregex>
        <regex>Regex</regex>
        <value>Value</value>
    </item>
    <item>
        <editheadertype>1</editheadertype>
        <header>Header</header>
        <hasregex>0</hasregex>
        <regex />
        <value>Value</value>
    </item>
</custom>".TrimStart();

        [Test]
        public void TRuleEditHeaderList()
        {
            var testClass = new TRuleEditHeaderList();
            testClass.Items.Add(new TRuleEditHeaderItem
            {
                EditHeaderType = TRuleEditHeaderType.AddEdit,
                Header = "Header",
                HasRegex = true,
                Regex = "Regex",
                Value = "Value"
            });
            testClass.Items.Add(new TRuleEditHeaderItem
            {
                EditHeaderType = TRuleEditHeaderType.Delete,
                Header = "Header",
                HasRegex = false,
                Regex = "",
                Value = "Value"
            });

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleEditHeaderList_BuildXmlElement()
        {
            var testClass = new TRuleEditHeaderList(GetXmlNode(_xml));

            Assert.AreEqual(2, testClass.Items.Count);

            Assert.AreEqual(TRuleEditHeaderType.AddEdit, testClass.Items.First().EditHeaderType);
            Assert.AreEqual("Header", testClass.Items.First().Header);
            Assert.True(testClass.Items.First().HasRegex);
            Assert.AreEqual("Regex", testClass.Items.First().Regex);
            Assert.AreEqual("Value", testClass.Items.First().Value);

            Assert.AreEqual(TRuleEditHeaderType.Delete, testClass.Items.Last().EditHeaderType);
            Assert.AreEqual("Header", testClass.Items.Last().Header);
            Assert.False(testClass.Items.Last().HasRegex);
            Assert.True(String.IsNullOrEmpty(testClass.Items.Last().Regex));
            Assert.AreEqual("Value", testClass.Items.Last().Value);
        }
    }
}
