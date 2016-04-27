using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Priority condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRulePriorityCondition">https://www.icewarp.co.uk/api/#TRulePriorityCondition</see></para>
    /// </summary>
    public class TRulePriorityCondition : TRuleCondition
    {
        /// <summary>
        /// Represents class property TRulePriorityCondition.Priority
        /// </summary>
        public TRulePriorityType Priority { get; set; }

        /// <inheritdoc />
        public TRulePriorityCondition()
        {
            ConditionType = TRuleConditionType.Priority;
        }

        /// <inheritdoc />
        public TRulePriorityCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Priority = (TRulePriorityType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Priority)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Priority), Priority);

            return element;
        }
    }
}
