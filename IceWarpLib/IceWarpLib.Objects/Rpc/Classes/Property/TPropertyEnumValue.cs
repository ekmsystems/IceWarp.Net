using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Describes value of property enumeration.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyEnumValue">https://www.icewarp.co.uk/api/#TPropertyEnumValue</see></para>
    /// </summary>
    public class TPropertyEnumValue : RpcBaseClass
    {
        /// <summary>
        /// Enumeration name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Enumeration value
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc />
        public TPropertyEnumValue() {  }

        /// <inheritdoc />
        public TPropertyEnumValue(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Value)));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Value), Value);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            return element;
        }
    }
}
