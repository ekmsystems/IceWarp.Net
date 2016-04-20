using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Represents property of server ,domain ,account ,mobile device or statistic object
    /// </summary>
    public class TAPIProperty : BaseClass
    {
        /// <summary>
        /// Property name as in apiconst.dat
        /// </summary>
        public string PropName { get; set; }

        public TAPIProperty() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAPIProperty(XmlNode node)
        {
            if (node != null)
            {
                PropName = Extensions.GetNodeInnerText(node.GetSingleNode("PropName"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "PropName", PropName);
            return element;
        }
    }
}
