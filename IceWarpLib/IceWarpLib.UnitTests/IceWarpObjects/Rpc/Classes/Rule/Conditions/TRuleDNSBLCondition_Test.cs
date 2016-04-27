using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleDNSBLCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulednsblcondition</classname>
    <conditiontype>27</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <server>server</server>
    <regex>regex</regex>
</custom>".TrimStart();

        [Test]
        public void TRuleDNSBLCondition()
        {
            var testClass = new TRuleDNSBLCondition
            {
                Server = "server",
                Regex = "regex"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleDNSBLCondition_BuildXmlElement()
        {
            var testClass = new TRuleDNSBLCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.DNSBL, testClass.ConditionType);
            Assert.AreEqual("server", testClass.Server);
            Assert.AreEqual("regex", testClass.Regex);
        }
    }
}
