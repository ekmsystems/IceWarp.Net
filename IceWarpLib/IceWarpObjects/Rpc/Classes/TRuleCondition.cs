using System.Xml;
using IceWarpObjects.Rpc.Enums;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Abstract class that represents rule condition
    /// Descendants:
    ///  - <see cref="TRuleSomeWordsCondition"/>
    ///  - <see cref="TRulePriorityCondition"/>
    ///  - <see cref="TRuleIsSpamCondition"/>
    ///  - <see cref="TRuleIsSizeCondition"/>
    ///  - <see cref="TRuleHasAttachmentCondition"/>
    ///  - <see cref="TRuleSenderRecipientCondition"/>
    ///  - <see cref="TRuleDNSBLCondition"/>
    ///  - <see cref="TRuleTrustedSessionCondition"/>
    ///  - <see cref="TRuleSpamScoreCondition"/>
    ///  - <see cref="TRuleSMTPAuthCondition"/>
    ///  - <see cref="TRuleLocalTimeCondition"/>
    ///  - <see cref="TRuleAllCondition"/>
    /// </summary>
    public abstract class TRuleCondition : BaseClass
    {
        /// <summary>
        /// Type of the condition
        /// </summary>
        public TRuleConditionType ConditionType { get; set; }
        /// <summary>
        /// Logical operator with previous condition ( OR if false )
        /// </summary>
        public bool OperatorAnd { get; set; }
        /// <summary>
        /// Negates the condition
        /// </summary>
        public bool LogicalNot { get; set; }
        /// <summary>
        /// Brackets on the left side of this condition
        /// </summary>
        public int BracketsLeft { get; set; }
        /// <summary>
        /// Brackets on the right side of this condition
        /// </summary>
        public int BracketsRight { get; set; }

        /// <summary>
        /// Populates fields from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        protected void ProcessNode(XmlNode node)
        {
            ConditionType = (TRuleConditionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("ConditionType"));
            OperatorAnd = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("OperatorAnd"));
            LogicalNot = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("LogicalNot"));
            BracketsLeft = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("BracketsLeft"));
            BracketsRight = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("BracketsRight"));
        }

        protected void AppendBaseElements(XmlElement element)
        {
            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "ConditionType", ConditionType);
            XmlHelper.AppendTextElement(element, "OperatorAnd", OperatorAnd);
            XmlHelper.AppendTextElement(element, "LogicalNot", LogicalNot);
            XmlHelper.AppendTextElement(element, "BracketsLeft", BracketsLeft);
            XmlHelper.AppendTextElement(element, "BracketsRight", BracketsRight);
        }
    }
}
