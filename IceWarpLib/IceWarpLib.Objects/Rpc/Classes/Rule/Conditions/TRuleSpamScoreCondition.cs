using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Spam score condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSpamScoreCondition">https://www.icewarp.co.uk/api/#TRuleSpamScoreCondition</see></para>
    /// </summary>
    public class TRuleSpamScoreCondition : TRuleCondition
    {
        /// <summary>
        /// Comparation type
        /// </summary>
        public TRuleCompareType CompareType { get; set; }
        /// <summary>
        /// Spam score value
        /// </summary>
        public string SpamScore { get; set; }

        /// <inheritdoc />
        public TRuleSpamScoreCondition()
        {
            ConditionType = TRuleConditionType.SpamScore;
        }

        /// <inheritdoc />
        public TRuleSpamScoreCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                CompareType = (TRuleCompareType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => CompareType)));
                SpamScore = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => SpamScore)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CompareType), CompareType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SpamScore), SpamScore);

            return element;
        }
    }
}
