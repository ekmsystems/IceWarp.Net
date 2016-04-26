using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that stops processing more rules in the list
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulestopaction</classname>
    ///     </custom>
    /// </code>
    public class TRuleStopAction : TRuleAction
    {
        public TRuleStopAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleStopAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);

            return element;
        }
    }
}
