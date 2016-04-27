using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents api property of type string.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyString">https://www.icewarp.co.uk/api/#TPropertyString</see></para>
    /// </summary>
    public class TPropertyString : TPropertyVal
    {
        /// <summary>
        /// String value
        /// </summary>
        public string Val { get; set; }

        /// <inheritdoc />
        public TPropertyString() { }

        /// <inheritdoc />
        public TPropertyString(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Val)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Val), Val);

            return element;
        }
    }
}
