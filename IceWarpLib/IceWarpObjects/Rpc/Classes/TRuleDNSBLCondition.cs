using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// RFC822 condition type Application condition type DNSBL server condition type
    /// </summary>
    public class TRuleDNSBLCondition : TRuleCondition
    {
        /// <summary>
        /// Server value
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Regex value
        /// </summary>
        public string Regex { get; set; }

        public TRuleDNSBLCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleDNSBLCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Server = Extensions.GetNodeInnerText(node.GetSingleNode("Server"));
                Regex = Extensions.GetNodeInnerText(node.GetSingleNode("Regex"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Server", Server);
            XmlHelper.AppendTextElement(element, "Regex", Regex);

            return element;
        }
    }
}
