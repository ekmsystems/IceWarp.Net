using System.Linq;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule
{
    public class TRuleSettings_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <conditions>
        <item>
            <classname>trulesomewordscondition</classname>
            <conditiontype>12</conditiontype>
            <operatorand>1</operatorand>
            <logicalnot>0</logicalnot>
            <bracketsleft>0</bracketsleft>
            <bracketsright>0</bracketsright>
            <matchfunction>3</matchfunction>
            <matchvalue>X-Priority: 2</matchvalue>
            <matchcase>0</matchcase>
            <matchwholewordsonly>0</matchwholewordsonly>
            <notmatch>0</notmatch>
            <multipleitemsmatch>0</multipleitemsmatch>
            <parsexml>0</parsexml>
        </item>
    </conditions>
    <actions>
        <item>
            <classname>trulemessageactionaction</classname>
            <actiontype>25</actiontype>
            <messageactiontype>2</messageactiontype>
        </item>
        <item>
            <classname>trulepriorityaction</classname>
            <actiontype>7</actiontype>
            <priority>1</priority>
        </item>
    </actions>
    <title>Test</title>
    <active>1</active>
    <ruleid>1</ruleid>
</custom>".TrimStart();

        [Test]
        public void TRuleSettings()
        {
            var testClass = new TRuleSettings
            {
                Title = "Test",
                Active = true,
                RuleID = 1
            };
            testClass.Conditions.Items.Add(new TRuleSomeWordsCondition
            {
                ConditionType = TRuleConditionType.CustomHeader,
                OperatorAnd = true,
                MatchFunction = TRuleSomeWordsFunctionType.Regex,
                MatchValue = "X-Priority: 2"
            });
            testClass.Actions.Items.Add(new TRuleMessageActionAction
            {
                Actiontype = TRuleActionType.MessageAction,
                MessageActionType = TRuleMessageActionType.Reject
            });
            testClass.Actions.Items.Add(new TRulePriorityAction
            {
                Actiontype = TRuleActionType.Priority,
                Priority = TRulePriorityType.Highest
            });

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSettings_BuildXmlElement()
        {
            var testClass = new TRuleSettings(GetXmlNode(_xml));

            Assert.AreEqual("Test", testClass.Title);
            Assert.True(testClass.Active);
            Assert.AreEqual(1, testClass.RuleID);

            Assert.AreEqual(1, testClass.Conditions.Items.Count);
            Assert.AreEqual(typeof(TRuleSomeWordsCondition), testClass.Conditions.Items.First().GetType());
            Assert.AreEqual(TRuleConditionType.CustomHeader, testClass.Conditions.Items.First().ConditionType);
            Assert.True(testClass.Conditions.Items.First().OperatorAnd);
            Assert.AreEqual(TRuleSomeWordsFunctionType.Regex, ((TRuleSomeWordsCondition)testClass.Conditions.Items.First()).MatchFunction);
            Assert.AreEqual("X-Priority: 2", ((TRuleSomeWordsCondition)testClass.Conditions.Items.First()).MatchValue);

            Assert.AreEqual(2, testClass.Actions.Items.Count);
            Assert.AreEqual(typeof(TRuleMessageActionAction), testClass.Actions.Items.First().GetType());
            Assert.AreEqual(TRuleActionType.MessageAction, testClass.Actions.Items.First().Actiontype);

            Assert.AreEqual(typeof(TRulePriorityAction), testClass.Actions.Items.Last().GetType());
            Assert.AreEqual(TRuleActionType.Priority, testClass.Actions.Items.Last().Actiontype);
        }
    }
}
