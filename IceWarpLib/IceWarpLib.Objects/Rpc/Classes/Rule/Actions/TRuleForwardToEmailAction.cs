using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that forwards an email
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>truleforwardtoemailaction</classname>
    ///         <email>stringval</email>
    ///     </custom>
    /// </code>
    public class TRuleForwardToEmailAction : TRuleAction
    {
        /// <summary>
        /// Email the message will be forwarded to
        /// </summary>
        public string Email { get; set; }

        public TRuleForwardToEmailAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleForwardToEmailAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Email = Extensions.GetNodeInnerText(node.GetSingleNode("Email"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Email", Email);

            return element;
        }
    }
}
