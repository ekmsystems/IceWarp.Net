using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Pair API property - right.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyRight">https://www.icewarp.co.uk/api/#TPropertyRight</see></para>
    /// </summary>
    public class TPropertyRight : RpcBaseClass
    {
        /// <summary>
        /// API Property object. See <see cref="TAPIProperty"/>
        /// </summary>
        public TAPIProperty APIProperty { get; set; }
        /// <summary>
        /// Property right. See <see cref="TPermission"/>
        /// </summary>
        public TPermission PropertyRight { get; set; }

        /// <inheritdoc />
        public TPropertyRight()
        {
            APIProperty = new TAPIProperty();
        }

        /// <inheritdoc />
        public TPropertyRight(XmlNode node)
        {
            if (node != null)
            {
                APIProperty = new TAPIProperty(node.GetSingleNode(ClassHelper.GetMemberName(() => APIProperty)));
                PropertyRight = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => PropertyRight)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(APIProperty.BuildXmlElement(doc, ClassHelper.GetMemberName(() => APIProperty)));
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropertyRight), PropertyRight);

            return element;
        }
    }
}
