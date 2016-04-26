using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that sets message priority
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulepriorityaction</classname>
    ///         <priority>enumval</priority>
    ///     </custom>
    /// </code>
    public class TRulePriorityAction : TRuleAction
    {
        /// <summary>
        /// Priority value
        /// </summary>
        public TRulePriorityType Priority { get; set; }

        public TRulePriorityAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRulePriorityAction(XmlNode node)
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
