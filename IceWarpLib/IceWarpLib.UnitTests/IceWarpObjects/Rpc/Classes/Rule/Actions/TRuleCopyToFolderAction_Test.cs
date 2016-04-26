using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleCopyToFolderAction_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulecopytofolderaction</classname>
    <actiontype>5</actiontype>
    <folder>target folder</folder>
</custom>".TrimStart();

        [Test]
        public void TRuleForwardToEmailAction()
        {
            var testClass = new TRuleCopyToFolderAction
            {
                Actiontype = TRuleActionType.CopyFolder,
                Folder = "target folder"
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleForwardToEmailAction_BuildXmlElement()
        {
            var testClass = new TRuleCopyToFolderAction(GetXmlNode(_xml));

            Assert.AreEqual(TRuleActionType.CopyFolder, testClass.Actiontype);
            Assert.AreEqual("target folder", testClass.Folder);
        }
    }
}
