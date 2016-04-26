using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Rule action that sends a message
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulesendmessageaction</classname>
    ///         <messagefrom>stringval</messagefrom>
    ///         <messageto>stringval</messageto>
    ///         <messagesubject>stringval</messagesubject>
    ///         <messagetext>stringval</messagetext>
    ///     </custom>
    /// </code>
    public class TRuleSendMessageAction : TRuleAction
    {
        /// <summary>
        /// Message From
        /// </summary>
        public string MessageFrom { get; set; }
        /// <summary>
        /// Message To
        /// </summary>
        public string MessageTo { get; set; }
        /// <summary>
        /// Message Subject
        /// </summary>
        public string MessageSubject { get; set; }
        /// <summary>
        /// Message Text body
        /// </summary>
        public string MessageText { get; set; }

        public TRuleSendMessageAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSendMessageAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MessageFrom = Extensions.GetNodeInnerText(node.GetSingleNode("MessageFrom"));
                MessageTo = Extensions.GetNodeInnerText(node.GetSingleNode("MessageTo"));
                MessageSubject = Extensions.GetNodeInnerText(node.GetSingleNode("MessageSubject"));
                MessageText = Extensions.GetNodeInnerText(node.GetSingleNode("MessageText"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "MessageFrom", MessageFrom);
            XmlHelper.AppendTextElement(element, "MessageTo", MessageTo);
            XmlHelper.AppendTextElement(element, "MessageSubject", MessageSubject);
            XmlHelper.AppendTextElement(element, "MessageText", MessageText);

            return element;
        }
    }
}
