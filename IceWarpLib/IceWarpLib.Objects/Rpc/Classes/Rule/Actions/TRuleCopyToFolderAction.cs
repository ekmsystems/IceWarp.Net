using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that copies the message into specified folder
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulecopytofolderaction</classname>
    ///         <folder>stringval</folder>
    ///     </custom>
    /// </code>
    public class TRuleCopyToFolderAction : TRuleAction
    {
        /// <summary>
        /// Target folder
        /// </summary>
        public string Folder { get; set; }

        public TRuleCopyToFolderAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleCopyToFolderAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Folder = Extensions.GetNodeInnerText(node.GetSingleNode("Folder"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Folder", Folder);

            return element;
        }
    }
}
