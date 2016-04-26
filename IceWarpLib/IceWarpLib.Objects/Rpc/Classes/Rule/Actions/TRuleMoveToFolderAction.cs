using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that moves the message into specified folder
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulemovetofolderaction</classname>
    ///         <folder>stringval</folder>
    ///     </custom>
    /// </code>
    public class TRuleMoveToFolderAction : TRuleAction
    {
        /// <summary>
        /// Target folder
        /// </summary>
        public string Folder { get; set; }

        public TRuleMoveToFolderAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleMoveToFolderAction(XmlNode node)
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
