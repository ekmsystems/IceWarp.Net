using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Simple action with the message (accept,delete,reject,spam,quarantine)
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulemessageactionaction</classname>
    ///         <messageactiontype>enumval</messageactiontype>
    ///     </custom>
    /// </code>
    public class TRuleMessageActionAction : TRuleAction
    {
        /// <summary>
        /// Type of the message action
        /// </summary>
        public TRuleMessageActionType MessageActionType { get; set; }

        public TRuleMessageActionAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleMessageActionAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MessageActionType = (TRuleMessageActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("MessageActionType"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "MessageActionType", MessageActionType);

            return element;
        }
    }
}
