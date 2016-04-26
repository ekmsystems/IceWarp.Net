using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleMessageActionAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulemessageactionaction</classname>
    <actiontype>25</actiontype>
    <messageactiontype>2</messageactiontype>
</custom>".TrimStart();

        [Test]
        public void TRuleMessageActionAction()
        {
            var testClass = new TRuleMessageActionAction
            {
                Actiontype = TRuleActionType.MessageAction,
                MessageActionType = TRuleMessageActionType.Reject
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleMessageActionAction_BuildXmlElement()
        {
            var testClass = new TRuleMessageActionAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.MessageAction, testClass.Actiontype);
            Assert.AreEqual(TRuleMessageActionType.Reject, testClass.MessageActionType);
        }
    }
}
