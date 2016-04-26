using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Item that represents header modification
    /// </summary>
    public class TRuleEditHeaderItem : BaseClass
    {
        /// <summary>
        /// Type of action
        /// </summary>
        public TRuleEditHeaderType EditHeaderType { get; set; }
        /// <summary>
        /// Header name
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// If uses regex
        /// </summary>
        public bool HasRegex { get; set; }
        /// <summary>
        /// Regex value
        /// </summary>
        public string Regex { get; set; }
        /// <summary>
        /// Header value
        /// </summary>
        public string Value { get; set; }

        public TRuleEditHeaderItem() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleEditHeaderItem(XmlNode node)
        {
            if (node != null)
            {
                EditHeaderType = (TRuleEditHeaderType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("EditHeaderType"));
                Header = Extensions.GetNodeInnerText(node.GetSingleNode("Header"));
                HasRegex = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("HasRegex"));
                Regex = Extensions.GetNodeInnerText(node.GetSingleNode("Regex"));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode("Value"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "EditHeaderType", EditHeaderType);
            XmlHelper.AppendTextElement(element, "Header", Header);
            XmlHelper.AppendTextElement(element, "HasRegex", HasRegex);
            XmlHelper.AppendTextElement(element, "Regex", Regex);
            XmlHelper.AppendTextElement(element, "Value", Value);

            return element;
        }
    }
}
