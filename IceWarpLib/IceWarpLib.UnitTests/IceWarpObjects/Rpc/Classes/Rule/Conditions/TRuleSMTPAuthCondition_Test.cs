using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleSMTPAuthCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulesmtpauthcondition</classname>
    <conditiontype>31</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
</custom>".TrimStart();

        [Test]
        public void TRuleSMTPAuthCondition()
        {
            var testClass = new TRuleSMTPAuthCondition();

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSMTPAuthCondition_BuildXmlElement()
        {
            var testClass = new TRuleSMTPAuthCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.SMTPAuth, testClass.ConditionType);
        }
    }
}
