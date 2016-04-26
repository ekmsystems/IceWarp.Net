using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleSendMessageAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulesendmessageaction</classname>
    <actiontype>1</actiontype>
    <messagefrom>message from</messagefrom>
    <messageto>message to</messageto>
    <messagesubject>message subject</messagesubject>
    <messagetext>message text</messagetext>
</custom>".TrimStart();

        [Test]
        public void TRuleSendMessageAction()
        {
            var testClass = new TRuleSendMessageAction
            {
                Actiontype = TRuleActionType.SendMessage,
                MessageFrom = "message from",
                MessageTo = "message to",
                MessageSubject = "message subject",
                MessageText = "message text"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSendMessageAction_BuildXmlElement()
        {
            var testClass = new TRuleSendMessageAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.SendMessage, testClass.Actiontype);
            Assert.AreEqual("message from", testClass.MessageFrom);
            Assert.AreEqual("message to", testClass.MessageTo);
            Assert.AreEqual("message subject", testClass.MessageSubject);
            Assert.AreEqual("message text", testClass.MessageText);
        }
    }
}
