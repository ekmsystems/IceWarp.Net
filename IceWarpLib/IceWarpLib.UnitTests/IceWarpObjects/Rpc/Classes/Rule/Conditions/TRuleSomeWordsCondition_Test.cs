using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;
using NUnit.Framework;

namespace IceWarpLib.UnitTests.IceWarpObjects.Rpc.Classes.Rule.Conditions
{
    public class TRuleSomeWordsCondition_Test : BaseTest
    {
        private string _xml = @"
<custom xmlns=""admin:iq:rpc"">
    <classname>trulesomewordscondition</classname>
    <conditiontype>0</conditiontype>
    <operatorand>0</operatorand>
    <logicalnot>0</logicalnot>
    <bracketsleft>0</bracketsleft>
    <bracketsright>0</bracketsright>
    <matchfunction>6</matchfunction>
    <matchvalue>TESTING</matchvalue>
    <matchcase>0</matchcase>
    <matchwholewordsonly>0</matchwholewordsonly>
    <notmatch>0</notmatch>
    <multipleitemsmatch>2</multipleitemsmatch>
    <parsexml>0</parsexml>
</custom>".TrimStart();

        [Test]
        public void TRuleSomeWordsCondition()
        {
            var testClass = new TRuleSomeWordsCondition
            {
                MatchValue = "TESTING",
                MatchFunction = TRuleSomeWordsFunctionType.Equals,
                MultipleItemsMatch = TRuleMultipleItemsMatchType.AtLeastOneMatch
            };

            var testXml = ToFormattedXml(testClass);
            Assert.AreEqual(_xml, testXml);
        }

        [Test]
        public void TRuleSomeWordsCondition_BuildXmlElement()
        {
            var testClass = new TRuleSomeWordsCondition(GetXmlNode(_xml));

            Assert.AreEqual("TESTING", testClass.MatchValue);
            Assert.AreEqual(TRuleSomeWordsFunctionType.Equals, testClass.MatchFunction);
            Assert.AreEqual(TRuleMultipleItemsMatchType.AtLeastOneMatch, testClass.MultipleItemsMatch);
        }

    }
}
