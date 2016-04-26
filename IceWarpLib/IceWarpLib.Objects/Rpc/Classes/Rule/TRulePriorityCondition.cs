using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Priority condition type
    /// </summary>
    public class TRulePriorityCondition : TRuleCondition
    {
        /// <summary>
        /// Represents class property TRulePriorityCondition.Priority
        /// </summary>
        public TRulePriorityType Priority { get; set; }

        public TRulePriorityCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRulePriorityCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Priority = (TRulePriorityType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Priority"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Priority", Priority);

            return element;
        }
    }
}
