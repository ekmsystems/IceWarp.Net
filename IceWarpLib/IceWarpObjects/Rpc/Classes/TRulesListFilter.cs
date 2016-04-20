using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Used to filter the list of rules in IceWarp server
    /// </summary>
    public class TRulesListFilter : BaseClass
    {
        /// <summary>
        /// Used against rule name
        /// </summary>
        public string NameMask { get; set; }
        
        public TRulesListFilter() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRulesListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode("NameMask"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "NameMask", NameMask);
            return element;
        }
    }
}
