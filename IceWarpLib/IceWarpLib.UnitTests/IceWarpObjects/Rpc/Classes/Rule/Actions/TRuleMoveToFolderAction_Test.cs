using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleMoveToFolderAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulemovetofolderaction</classname>
    <actiontype>4</actiontype>
    <folder>target folder</folder>
</custom>".TrimStart();

        [Test]
        public void TRuleForwardToEmailAction()
        {
            var testClass = new TRuleMoveToFolderAction
            {
                Actiontype = TRuleActionType.MoveFolder,
                Folder = "target folder"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleForwardToEmailAction_BuildXmlElement()
        {
            var testClass = new TRuleMoveToFolderAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.MoveFolder, testClass.Actiontype);
            Assert.AreEqual("target folder", testClass.Folder);
        }
    }
}
