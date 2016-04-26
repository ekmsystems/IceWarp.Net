using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Spam score condition type
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

        public TRuleSpamScoreCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSpamScoreCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                CompareType = (TRuleCompareType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("CompareType"));
                SpamScore = Extensions.GetNodeInnerText(node.GetSingleNode("SpamScore"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "CompareType", CompareType);
            XmlHelper.AppendTextElement(element, "SpamScore", SpamScore);

            return element;
        }
    }
}
