using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleLocalTimeCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulelocaltimecondition</classname>
    <conditiontype>33</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <weekdays>1</weekdays>
    <monday>0</monday>
    <tuesday>0</tuesday>
    <wednesday>0</wednesday>
    <thursday>0</thursday>
    <friday>0</friday>
    <saturday>0</saturday>
    <sunday>0</sunday>
    <betweentimes>0</betweentimes>
    <fromtime />
    <totime />
    <betweendates>0</betweendates>
    <fromdate />
    <todate />
</custom>".TrimStart();

        [Test]
        public void TRuleLocalTimeCondition()
        {
            var testClass = new TRuleLocalTimeCondition
            {
                Weekdays = true
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleLocalTimeCondition_BuildXmlElement()
        {
            var testClass = new TRuleLocalTimeCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.Time, testClass.ConditionType);
            Assert.True(testClass.Weekdays);
        }
    }
}
