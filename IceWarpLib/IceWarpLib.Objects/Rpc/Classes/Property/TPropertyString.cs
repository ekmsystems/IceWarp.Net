using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents api property of type string
    /// </summary>
    public class TPropertyString : TPropertyVal
    {
        /// <summary>
        /// String value
        /// </summary>
        public string Val { get; set; }
        
        public TPropertyString() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyString(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode("Val"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Val", Val);

            return element;
        }
    }
}
