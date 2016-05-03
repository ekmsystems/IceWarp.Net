using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Abstract class that represents rule condition.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleCondition">https://www.icewarp.co.uk/api/#TRuleCondition</see></para>
    /// <para/>Descendants:
    /// <para/><see cref="TRuleSomeWordsCondition"/>
    /// <para/><see cref="TRulePriorityCondition"/>
    /// <para/><see cref="TRuleIsSpamCondition"/>
    /// <para/><see cref="TRuleIsSizeCondition"/>
    /// <para/><see cref="TRuleHasAttachmentCondition"/>
    /// <para/><see cref="TRuleSenderRecipientCondition"/>
    /// <para/><see cref="TRuleDNSBLCondition"/>
    /// <para/><see cref="TRuleTrustedSessionCondition"/>
    /// <para/><see cref="TRuleSpamScoreCondition"/>
    /// <para/><see cref="TRuleSMTPAuthCondition"/>
    /// <para/><see cref="TRuleLocalTimeCondition"/>
    /// <para/><see cref="TRuleAllCondition"/>
    /// </summary>
    public abstract class TRuleCondition : RpcBaseClass
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
        /// Populates fields from an XML node.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/></param>
        protected void ProcessNode(XmlNode node)
        {
            ConditionType = (TRuleConditionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ConditionType)));
            OperatorAnd = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => OperatorAnd)));
            LogicalNot = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => LogicalNot)));
            BracketsLeft = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => BracketsLeft)));
            BracketsRight = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => BracketsRight)));
        }
        /// <summary>
        /// Appends base fields to an XML element.
        /// </summary>
        /// <param name="element">The XML element. See <see cref="XmlElement"/></param>
        protected void AppendBaseElements(XmlElement element)
        {
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ConditionType), ConditionType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => OperatorAnd), OperatorAnd);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LogicalNot), LogicalNot);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BracketsLeft), BracketsLeft);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BracketsRight), BracketsRight);
        }
    }
}
