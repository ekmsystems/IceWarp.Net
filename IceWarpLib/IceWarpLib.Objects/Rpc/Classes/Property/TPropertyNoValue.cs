using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents property that has no value or there are missing read permissions.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyNoValue">https://www.icewarp.co.uk/api/#TPropertyNoValue</see></para>
    /// </summary>
    public class TPropertyNoValue : TPropertyVal
    {
        /// <inheritdoc />
        public TPropertyNoValue()
        {
        }

        /// <inheritdoc />
        public TPropertyNoValue(XmlNode node)
        {
            
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);

            return element;
        }
    }
}
