using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRulePriorityAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulepriorityaction</classname>
    <actiontype>7</actiontype>
    <priority>1</priority>
</custom>".TrimStart();

        [Test]
        public void TRulePriorityAction()
        {
            var testClass = new TRulePriorityAction
            {
                Actiontype = TRuleActionType.Priority,
                Priority = TRulePriorityType.Highest
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRulePriorityAction_BuildXmlElement()
        {
            var testClass = new TRulePriorityAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Priority, testClass.Actiontype);
            Assert.AreEqual(TRulePriorityType.Highest, testClass.Priority);
        }
    }
}
