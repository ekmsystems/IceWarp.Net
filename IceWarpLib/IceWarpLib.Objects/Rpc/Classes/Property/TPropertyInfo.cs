using System;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Brief information about API property on IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyInfo">https://www.icewarp.co.uk/api/#TPropertyInfo</see></para>
    /// </summary>
    public class TPropertyInfo : RpcBaseClass
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

        /// <inheritdoc />
        public TPropertyInfo()
        {
            APIProperty = new TAPIProperty();
            PropertyVal = new TPropertyNoValue();
        }

        /// <inheritdoc />
        public TPropertyInfo(XmlNode node)
        {
            if (node != null)
            {
                APIProperty = new TAPIProperty(node.GetSingleNode(ClassHelper.GetMemberName(() => APIProperty)));

                var propertyVal = node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyVal));
                if (propertyVal != null)
                {
                    var className = Extensions.GetNodeInnerText(propertyVal.GetSingleNode(XmlHelper.ClassNameTag));
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

                PropertyRight = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyRight)));
                PropertyEnumValues = new TPropertyEnumValues(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyEnumValues)));
                PropertyComment = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyComment)));
                PropertyGroup = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyGroup)));
                PropertyValueType = (TPropertyValueType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyValueType)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, ClassHelper.GetMemberName(() => APIProperty)));
            element.AppendChild(PropertyVal.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyVal)));
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyRight), PropertyRight);
            if (PropertyEnumValues != null)
            {
                element.AppendChild(PropertyEnumValues.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyEnumValues)));
            }
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyComment), PropertyComment);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyGroup), PropertyGroup);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyValueType), PropertyValueType);

            return element;
        }
    }
}
