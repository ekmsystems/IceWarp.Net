using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// IceWarp account auto responder message
    /// </summary>
    public class TAccountResponderMessage : TPropertyVal
    {
        /// <summary>
        /// Header from: value in responder message
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Header subject: value in responder message
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Text content of responder message
        /// </summary>
        public string Text { get; set; }
        
        public TAccountResponderMessage()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountResponderMessage(XmlNode node)
        {
            if (node != null)
            {
                From = Extensions.GetNodeInnerText(node.GetSingleNode("From"));
                Subject = Extensions.GetNodeInnerText(node.GetSingleNode("Subject"));
                Text = Extensions.GetNodeInnerText(node.GetSingleNode("Text"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "From", From);
            XmlHelper.AppendTextElement(element, "Subject", Subject);
            XmlHelper.AppendTextElement(element, "Text", Text);

            return element;
        }
    }
}
