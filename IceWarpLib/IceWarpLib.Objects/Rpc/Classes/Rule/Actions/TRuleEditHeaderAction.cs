using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that copies the message into specified folder
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>truleeditheaderaction</classname>
    ///         <headers>
    ///           <item>
    ///             <editheadertype>enumval</editheadertype>
    ///             <header>stringval</header>
    ///             <hasregex>boolval</hasregex>
    ///             <regex>stringval</regex>
    ///             <value>stringval</value>
    ///           </item>
    ///           <item>
    ///             <editheadertype>enumval</editheadertype>
    ///             <header>stringval</header>
    ///             <hasregex>boolval</hasregex>
    ///             <regex>stringval</regex>
    ///             <value>stringval</value>
    ///           </item>
    ///         </headers>
    ///     </custom>
    /// </code>
    public class TRuleEditHeaderAction : TRuleAction
    {
        /// <summary>
        /// Target folder
        /// </summary>
        public TRuleEditHeaderList Headers { get; set; }

        public TRuleEditHeaderAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleEditHeaderAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Headers = new TRuleEditHeaderList(node.GetSingleNode("Headers"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            element.AppendChild(Headers.BuildXmlElement(doc, "Headers"));

            return element;
        }
    }
}
