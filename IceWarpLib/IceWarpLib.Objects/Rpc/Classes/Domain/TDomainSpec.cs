using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// This class represents a domain, or domain pattern using wildcards
    /// </summary>
    public class TDomainSpec : BaseClass
    {
        /// <summary>
        /// Domain name or pattern
        /// </summary>
        public string Mask { get; set; }
        /// <summary>
        /// Negates the Mask
        /// </summary>
        public bool Negate { get; set; }

        public TDomainSpec()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainSpec(XmlNode node)
        {
            if (node != null)
            {
                Mask = Extensions.GetNodeInnerText(node.GetSingleNode("Mask"));
                Negate = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Negate"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Mask", Mask);
            XmlHelper.AppendTextElement(element, "Negate", Negate);

            return element;
        }
    }
}
