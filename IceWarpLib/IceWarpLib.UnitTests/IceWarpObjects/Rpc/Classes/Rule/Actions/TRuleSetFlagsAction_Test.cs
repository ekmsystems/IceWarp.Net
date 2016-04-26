using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleSetFlagsAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulesetflagsaction</classname>
    <actiontype>9</actiontype>
    <flagged>0</flagged>
    <seen>0</seen>
    <junk>0</junk>
    <notjunk>0</notjunk>
    <label1>0</label1>
    <label2>0</label2>
    <label3>0</label3>
    <label4>0</label4>
    <label5>0</label5>
    <label6>0</label6>
</custom>".TrimStart();

        [Test]
        public void TRuleSetFlagsAction()
        {
            var testClass = new TRuleSetFlagsAction
            {
                Actiontype = TRuleActionType.Flags
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSetFlagsAction_BuildXmlElement()
        {
            var testClass = new TRuleSetFlagsAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.Flags, testClass.Actiontype);
            Assert.False(testClass.Flagged);
            Assert.False(testClass.Seen);
            Assert.False(testClass.Junk);
            Assert.False(testClass.NotJunk);
            Assert.False(testClass.Label1);
            Assert.False(testClass.Label2);
            Assert.False(testClass.Label3);
            Assert.False(testClass.Label4);
            Assert.False(testClass.Label5);
            Assert.False(testClass.Label6);
        }
    }
}
