using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleEditHeaderAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>truleeditheaderaction</classname>
    <actiontype>10</actiontype>
    <headers>
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
    </headers>
</custom>".TrimStart();

        [Test]
        public void TRuleEditHeaderAction()
        {
            var testClass = new TRuleEditHeaderAction
            {
                Actiontype = TRuleActionType.Header,
                Headers = new TRuleEditHeaderList
                {
                    Items = new List<TRuleEditHeaderItem>
                    {
                        new TRuleEditHeaderItem
                        {
                            EditHeaderType = TRuleEditHeaderType.AddEdit,
                            Header = "Header",
                            HasRegex = true,
                            Regex = "Regex",
                            Value = "Value"
                        },
                        new TRuleEditHeaderItem
                        {
                            EditHeaderType = TRuleEditHeaderType.Delete,
                            Header = "Header",
                            HasRegex = false,
                            Regex = "",
                            Value = "Value"
                        }
                    }
                }
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleEditHeaderAction_BuildXmlElement()
        {
            var testClass = new TRuleEditHeaderAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Header, testClass.Actiontype);
            Assert.AreEqual(2, testClass.Headers.Items.Count);

            Assert.AreEqual(TRuleEditHeaderType.AddEdit, testClass.Headers.Items.First().EditHeaderType);
            Assert.AreEqual("Header", testClass.Headers.Items.First().Header);
            Assert.True(testClass.Headers.Items.First().HasRegex);
            Assert.AreEqual("Regex", testClass.Headers.Items.First().Regex);
            Assert.AreEqual("Value", testClass.Headers.Items.First().Value);

            Assert.AreEqual(TRuleEditHeaderType.Delete, testClass.Headers.Items.Last().EditHeaderType);
            Assert.AreEqual("Header", testClass.Headers.Items.Last().Header);
            Assert.False(testClass.Headers.Items.Last().HasRegex);
            Assert.True(String.IsNullOrEmpty(testClass.Headers.Items.Last().Regex));
            Assert.AreEqual("Value", testClass.Headers.Items.Last().Value);
        }
    }
}
