using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleStopAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulestopaction</classname>
    <actiontype>27</actiontype>
</custom>".TrimStart();

        [Test]
        public void TRuleStopAction()
        {
            var testClass = new TRuleStopAction
            {
                Actiontype = TRuleActionType.Stop
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleStopAction_BuildXmlElement()
        {
            var testClass = new TRuleStopAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Stop, testClass.Actiontype);
        }
    }
}
