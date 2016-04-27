using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleHasAttachmentCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulehasattachmentcondition</classname>
    <conditiontype>17</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
</custom>".TrimStart();

        [Test]
        public void TRuleHasAttachmentCondition()
        {
            var testClass = new TRuleHasAttachmentCondition();

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleHasAttachmentCondition_BuildXmlElement()
        {
            var testClass = new TRuleHasAttachmentCondition(GetXmlNode(_xml));

            Assert.AreEqual(TRuleConditionType.HasAttach, testClass.ConditionType);
        }
    }
}
