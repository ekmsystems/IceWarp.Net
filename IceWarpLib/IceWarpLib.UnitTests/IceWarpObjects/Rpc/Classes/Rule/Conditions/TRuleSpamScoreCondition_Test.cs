using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleSpamScoreCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulespamscorecondition</classname>
    <conditiontype>29</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <comparetype>0</comparetype>
    <spamscore>10</spamscore>
</custom>".TrimStart();

        [Test]
        public void TRuleSpamScoreCondition()
        {
            var testClass = new TRuleSpamScoreCondition
            {
                CompareType = TRuleCompareType.Lower,
                SpamScore = "10"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSpamScoreCondition_BuildXmlElement()
        {
            var testClass = new TRuleSpamScoreCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.SpamScore, testClass.ConditionType);
            Assert.AreEqual(TRuleCompareType.Lower, testClass.CompareType);
            Assert.AreEqual("10", testClass.SpamScore);
        }
    }
}
