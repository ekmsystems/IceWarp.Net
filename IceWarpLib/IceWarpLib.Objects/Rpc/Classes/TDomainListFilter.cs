using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Used to filter the list of domains in IceWarp server
    /// </summary>
    public class TDomainListFilter : BaseClass
    {
        /// <summary>
        /// Used against domain name & description
        /// </summary>
        public string NameMask { get; set; }
        /// <summary>
        /// Used against domain type
        /// </summary>
        public TDomainType? TypeMask { get; set; }
        /// <summary>
        /// Returns the name of the class.
        /// </summary>
        public string ClassName { get { return this.GetType().Name.ToLower(); } }

        public TDomainListFilter() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode("NameMask"));
                TypeMask = (TDomainType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("TypeMask"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "NameMask", NameMask);
            XmlHelper.AppendTextElement(element, "TypeMask", TypeMask);
            return element;
        }
    }
}
