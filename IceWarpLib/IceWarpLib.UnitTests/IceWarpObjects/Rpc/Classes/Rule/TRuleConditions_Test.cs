using System.Linq;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule
{
    public class TRuleConditions_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <item>
        <classname>truletrustedsessioncondition</classname>
        <conditiontype>0</conditiontype>
        <operatorand>0</operatorand>
        <logicalnot>0</logicalnot>
        <bracketsleft>0</bracketsleft>
        <bracketsright>0</bracketsright>
    </item>
    <item>
        <classname>trulednsblcondition</classname>
        <conditiontype>0</conditiontype>
        <operatorand>0</operatorand>
        <logicalnot>0</logicalnot>
        <bracketsleft>0</bracketsleft>
        <bracketsright>0</bracketsright>
        <server>server</server>
        <regex>regex</regex>
    </item>
</custom>".TrimStart();

        [Test]
        public void TRuleAllConditions()
        {
            var testClass = new TRuleConditions();
            testClass.Items.Add(new TRuleTrustedSessionCondition());
            testClass.Items.Add(new TRuleDNSBLCondition
            {
                Server = "server",
                Regex = "regex"
            });

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleAllConditions_BuildXmlElement()
        {
            var testClass = new TRuleConditions(GetXmlNode(_xml));

            Assert.AreEqual(2, testClass.Items.Count);

            Assert.AreEqual(typeof(TRuleTrustedSessionCondition), testClass.Items.First().GetType());
            Assert.AreEqual(TRuleConditionType.None, testClass.Items.First().ConditionType);

            Assert.AreEqual(typeof(TRuleDNSBLCondition), testClass.Items.Last().GetType());
            Assert.AreEqual(TRuleConditionType.None, testClass.Items.Last().ConditionType);
            Assert.AreEqual("server", ((TRuleDNSBLCondition)testClass.Items.Last()).Server);
            Assert.AreEqual("regex", ((TRuleDNSBLCondition)testClass.Items.Last()).Regex);
        }
    }
}
