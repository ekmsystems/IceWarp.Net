using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleIsSizeCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>truleissizecondition</classname>
    <conditiontype>10</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <comparetype>0</comparetype>
    <size>0</size>
</custom>".TrimStart();

        [Test]
        public void TRuleIsSizeCondition()
        {
            var testClass = new TRuleIsSizeCondition();

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleIsSizeCondition_BuildXmlElement()
        {
            var testClass = new TRuleIsSizeCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleCompareType.Lower, testClass.CompareType);
            Assert.AreEqual(TRuleConditionType.Size, testClass.ConditionType);
        }
    }
}
