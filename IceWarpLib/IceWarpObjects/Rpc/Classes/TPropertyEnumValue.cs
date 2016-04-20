using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Describes value of property enumeration
    /// </summary>
    public class TPropertyEnumValue : BaseClass
    {
        /// <summary>
        /// Enumeration name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Enumeration value
        /// </summary>
        public string Value { get; set; }
        
        public TPropertyEnumValue() {  }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyEnumValue(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Value"));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "Value", Value);
            XmlHelper.AppendTextElement(element, "Name", Name);
            return element;
        }
    }
}
