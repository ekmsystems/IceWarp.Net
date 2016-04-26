using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleEncryptAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>truleencryptaction</classname>
    <actiontype>6</actiontype>
</custom>".TrimStart();

        [Test]
        public void TRuleEncryptAction()
        {
            var testClass = new TRuleEncryptAction
            {
                Actiontype = TRuleActionType.Encrypt
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleEncryptAction_BuildXmlElement()
        {
            var testClass = new TRuleEncryptAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Encrypt, testClass.Actiontype);
        }
    }
}
