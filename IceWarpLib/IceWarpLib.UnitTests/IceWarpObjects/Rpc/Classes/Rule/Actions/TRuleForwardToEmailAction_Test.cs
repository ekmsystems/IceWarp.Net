using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleForwardToEmailAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>truleforwardtoemailaction</classname>
    <actiontype>2</actiontype>
    <email>email address</email>
</custom>".TrimStart();

        [Test]
        public void TRuleForwardToEmailAction()
        {
            var testClass = new TRuleForwardToEmailAction
            {
                Actiontype = TRuleActionType.Forward,
                Email = "email address"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleForwardToEmailAction_BuildXmlElement()
        {
            var testClass = new TRuleForwardToEmailAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Forward, testClass.Actiontype);
            Assert.AreEqual("email address", testClass.Email);
        }
    }
}
