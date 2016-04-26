using System;
using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Actions
{
    public class TRuleActions_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <item>
        <classname>truleencryptaction</classname>
        <actiontype>6</actiontype>
    </item>
    <item>
        <classname>trulestopaction</classname>
        <actiontype>27</actiontype>
    </item>
</custom>".TrimStart();

        [Test]
        public void TRuleActions()
        {
            var testClass = new TRuleActions();
            testClass.Items.Add(new TRuleEncryptAction { Actiontype = TRuleActionType.Encrypt });
            testClass.Items.Add(new TRuleStopAction { Actiontype = TRuleActionType.Stop });

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleActions_BuildXmlElement()
        {
            var testClass = new TRuleActions(GetXmlNode(_xml));

            Assert.AreEqual(2, testClass.Items.Count);

            Assert.AreEqual(typeof(TRuleEncryptAction), testClass.Items.First().GetType());
            Assert.AreEqual(TRuleActionType.Encrypt, testClass.Items.First().Actiontype);

            Assert.AreEqual(typeof(TRuleStopAction), testClass.Items.Last().GetType());
            Assert.AreEqual(TRuleActionType.Stop, testClass.Items.Last().Actiontype);
        }
    }
}
