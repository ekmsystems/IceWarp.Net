using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that sets message priority.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRulePriorityAction">https://www.icewarp.co.uk/api/#TRulePriorityAction</see></para>
    /// </summary>
    public class TRulePriorityAction : TRuleAction
    {
        /// <summary>
        /// Priority value
        /// </summary>
        public TRulePriorityType Priority { get; set; }

        /// <inheritdoc />
        public TRulePriorityAction()
        {
            Actiontype = TRuleActionType.Priority;
        }

        /// <inheritdoc />
        public TRulePriorityAction(XmlNode node)
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
