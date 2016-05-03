using System;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents the value of any API property.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyValue">https://www.icewarp.co.uk/api/#TPropertyValue</see></para>
    /// </summary>
    public class TPropertyValue : RpcBaseClass
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

        /// <inheritdoc />
        public TPropertyValue()
        {
            APIProperty = new TAPIProperty();
            PropertyVal = new TPropertyNoValue();
        }

        /// <inheritdoc />
        public TPropertyValue(XmlNode node)
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
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, ClassHelper.GetMemberName(() => APIProperty)));
            element.AppendChild(PropertyVal.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyVal)));
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyRight), PropertyRight);

            return element;
        }
    }
}
