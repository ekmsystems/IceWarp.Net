using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Basic information about an IceWarp domain object
    /// </summary>
    public class TDomainInfo : BaseClass
    {
        /// <summary>
        /// Domain name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Domain description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Domain type. See <see cref="TDomainType"/>
        /// </summary>
        public TDomainType DomainType { get; set; }
        /// <summary>
        /// Number of accounts
        /// </summary>
        public int AccountCount { get; set; }
        
        public TDomainInfo() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
                Desc = Extensions.GetNodeInnerText(node.GetSingleNode("Desc"));
                DomainType = (TDomainType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("DomainType"));
                AccountCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("AccountCount"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Name", Name);
            XmlHelper.AppendTextElement(element, "Desc", Desc);
            XmlHelper.AppendTextElement(element, "DomainType", DomainType);
            XmlHelper.AppendTextElement(element, "AccountCount", AccountCount);

            return element;
        }
    }
}
