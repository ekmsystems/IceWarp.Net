using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleSenderRecipientCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulesenderrecipientcondition</classname>
    <conditiontype>21</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <recipientsender>0</recipientsender>
    <remotelocal>1</remotelocal>
    <recipientcondition>1</recipientcondition>
    <account>test</account>
</custom>".TrimStart();

        [Test]
        public void TRuleSenderRecipientCondition()
        {
            var testClass = new TRuleSenderRecipientCondition
            {
                Account = "test",
                RemoteLocal = TRuleRemoteLocalType.Local,
                RecipientCondition = TRuleRecipientConditionType.AccountExists
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSenderRecipientCondition_BuildXmlElement()
        {
            var testClass = new TRuleSenderRecipientCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.SenderRecipient, testClass.ConditionType);
            Assert.AreEqual(TRuleRecipientSenderType.Sender, testClass.RecipientSender);
            Assert.AreEqual(TRuleRemoteLocalType.Local, testClass.RemoteLocal);
            Assert.AreEqual(TRuleRecipientConditionType.AccountExists, testClass.RecipientCondition);
            Assert.AreEqual("test", testClass.Account);
        }
    }
}
