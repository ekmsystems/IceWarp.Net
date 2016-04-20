using IceWarpObjects.Rpc.Classes;
using IceWarpObjects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes
{
    public class TRuleSpamScoreCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulespamscorecondition</classname>
    <conditiontype>0</conditiontype>
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

            Assert.AreEqual(TRuleConditionType.None, testClass.ConditionType);
            Assert.AreEqual(TRuleCompareType.Lower, testClass.CompareType);
            Assert.AreEqual("10", testClass.SpamScore);
        }
    }
}
