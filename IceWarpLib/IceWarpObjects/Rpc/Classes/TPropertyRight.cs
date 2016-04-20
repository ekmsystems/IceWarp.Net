using System.Xml;
using IceWarpObjects.Rpc.Enums;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Pair API property - right
    /// </summary>
    public class TPropertyRight : BaseClass
    {
        /// <summary>
        /// API Property object. See <see cref="TAPIProperty"/>
        /// </summary>
        public TAPIProperty APIProperty { get; set; }
        /// <summary>
        /// Property right. See <see cref="TPermission"/>
        /// </summary>
        public TPermission PropertyRight { get; set; }
        
        public TPropertyRight()
        {
            APIProperty = new TAPIProperty();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyRight(XmlNode node)
        {
            if (node != null)
            {
                APIProperty = new TAPIProperty(node.GetSingleNode("APIProperty"));
                PropertyRight = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("PropertyRight"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, "APIProperty"));
            XmlHelper.AppendTextElement(element, "PropertyRight", PropertyRight);

            return element;
        }
    }
}
