using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleIsSpamCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>truleisspamcondition</classname>
    <conditiontype>9</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
</custom>".TrimStart();

        [Test]
        public void TRuleIsSpamCondition()
        {
            var testClass = new TRuleIsSpamCondition();

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleIsSpamCondition_BuildXmlElement()
        {
            var testClass = new TRuleIsSpamCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.Spam, testClass.ConditionType);
        }
    }
}
