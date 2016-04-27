using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Account avatar image object which is displayed in account's vCard.
    /// <para>><see href="https://www.icewarp.co.uk/api/#TAccountImage">https://www.icewarp.co.uk/api/#TAccountImage</see></para
    /// </summary>
    public class TAccountImage : TPropertyVal
    {
        /// <summary>
        /// Image Base64 data
        /// </summary>
        public string Base64Data { get; set; }
        /// <summary>
        /// Image Content-Type
        /// </summary>
        public string ContentType { get; set; }

        /// <inheritdoc />
        public TAccountImage() { }
        
        /// <inheritdoc />
        public TAccountImage(XmlNode node)
        {
            if (node != null)
            {
                Base64Data = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Base64Data)));
                ContentType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ContentType)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Base64Data), Base64Data);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ContentType), ContentType);
            return element;
        }
    }
}
