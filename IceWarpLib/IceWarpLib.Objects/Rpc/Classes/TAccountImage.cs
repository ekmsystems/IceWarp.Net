using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Account avatar image object which is displayed in account's vCard
    /// </summary>
    public class TAccountImage : BaseClass
    {
        /// <summary>
        /// Image Base64 data
        /// </summary>
        public string Base64Data { get; set; }
        /// <summary>
        /// Image Content-Type
        /// </summary>
        public string ContentType { get; set; }
        
        public TAccountImage() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountImage(XmlNode node)
        {
            if (node != null)
            {
                Base64Data = Extensions.GetNodeInnerText(node.GetSingleNode("Base64Data"));
                ContentType = Extensions.GetNodeInnerText(node.GetSingleNode("ContentType"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Base64Data", Base64Data);
            XmlHelper.AppendTextElement(element, "ContentType", ContentType);
            return element;
        }
    }
}
