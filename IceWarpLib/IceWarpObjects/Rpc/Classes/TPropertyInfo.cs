using System;
using System.Linq;
using System.Xml;
using IceWarpObjects.Rpc.Enums;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Brief information about API property on IceWarp server
    /// </summary>
    public class TPropertyInfo : BaseClass
    {
        /// <summary>
        /// API Proprety object
        /// </summary>
        public TAPIProperty APIProperty { get; set; }
        /// <summary>
        /// Value of current API property
        /// </summary>
        public TPropertyVal PropertyVal { get; set; }
        /// <summary>
        /// Rights for the current session
        /// </summary>
        public TPermission PropertyRight { get; set; }
        /// <summary>
        /// Enumeration values & comments if the property is enumeration
        /// </summary>
        public TPropertyEnumValues PropertyEnumValues { get; set; }
        /// <summary>
        /// Comment ( description ) for current API Property
        /// </summary>
        public string PropertyComment { get; set; }
        /// <summary>
        /// Specifies the group in which the API property is organized
        /// </summary>
        public string PropertyGroup { get; set; }
        /// <summary>
        /// Type of the property value
        /// </summary>
        public TPropertyValueType PropertyValueType { get; set; }
        
        public TPropertyInfo()
        {
            APIProperty = new TAPIProperty();
            PropertyVal = new TPropertyNoValue();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyInfo(XmlNode node)
        {
            if (node != null)
            {
                APIProperty = new TAPIProperty(node.GetSingleNode("APIProperty"));

                var propertyVal = node.GetSingleNode("PropertyVal");
                if (propertyVal != null)
                {
                    var className = Extensions.GetNodeInnerText(propertyVal.GetSingleNode("ClassName"));
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

                PropertyRight = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("propertyright"));
                PropertyEnumValues = new TPropertyEnumValues(node.GetSingleNode("PropertyEnumValues"));
                PropertyComment = Extensions.GetNodeInnerText(node.GetSingleNode("PropertyComment"));
                PropertyGroup = Extensions.GetNodeInnerText(node.GetSingleNode("PropertyGroup"));
                PropertyValueType = (TPropertyValueType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("PropertyValueType"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, "APIProperty"));
            element.AppendChild(PropertyVal.BuildXmlElement(doc, "PropertyVal"));
            if (PropertyEnumValues != null)
            {
                element.AppendChild(PropertyEnumValues.BuildXmlElement(doc, "PropertyEnumValues"));
            }
            XmlHelper.AppendTextElement(element, "PropertyComment", PropertyComment);
            XmlHelper.AppendTextElement(element, "PropertyGroup", PropertyGroup);
            XmlHelper.AppendTextElement(element, "PropertyValueType", PropertyValueType);

            return element;
        }
    }
}
