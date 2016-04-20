using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Used to filter the list of accounts in IceWarp server
    /// </summary>
    public class TAccountListFilter : BaseClass
    {
        /// <summary>
        /// Mask that is used agains account name and alias
        /// </summary>
        public string NameMask { get; set; }
        /// <summary>
        /// Mask that is used agains account type
        /// </summary>
        public AccountType? TypeMask { get; set; }
        
        public TAccountListFilter() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode("NameMask"));
                TypeMask = (AccountType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("TypeMask"));
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
