using System;
using System.Linq;
using System.Xml;
using IceWarpObjects.Rpc.Enums;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Represents the value of any API property
    /// </summary>
    public class TPropertyValue : BaseClass
    {
        /// <summary>
        /// API Property object. See <see cref="TAPIProperty"/>
        /// </summary>
        public TAPIProperty APIProperty { get; set; }
        /// <summary>
        /// API Property value. See <see cref="TPropertyVal"/>
        /// </summary>
        public TPropertyVal PropertyVal { get; set; }
        /// <summary>
        /// API Property right. See <see cref="TPermission"/>
        /// </summary>
        public TPermission PropertyRight { get; set; }
        
        public TPropertyValue()
        {
            APIProperty = new TAPIProperty();
            PropertyVal = new TPropertyNoValue();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyValue(XmlNode node)
        {
            if (node != null)
            {
                APIProperty = new TAPIProperty(node.GetSingleNode("APIProperty"));

                var propertyVal = node.GetSingleNode("PropertyVal");
                if (propertyVal != null)
                {
                    var className = Extensions.GetNodeInnerText(propertyVal.GetSingleNode("classname"));
                    if (!String.IsNullOrEmpty(className))
                    {
                        var classType = ClassHelper.TPropertyValClasses()
                                                   .FirstOrDefault(x => x.ClassName.ToLower() == className.ToLower());
                        if (classType != null)
                        {
                            PropertyVal = (TPropertyVal)ClassHelper.GetInstance(classType.AssemblyQualifiedName, new[] { propertyVal });
                        }
                    }
                }

                PropertyRight = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("PropertyRight"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, "APIProperty"));
            element.AppendChild(PropertyVal.BuildXmlElement(doc, "PropertyVal"));
            XmlHelper.AppendTextElement(element, "PropertyRight", PropertyRight);

            return element;
        }
    }
}
