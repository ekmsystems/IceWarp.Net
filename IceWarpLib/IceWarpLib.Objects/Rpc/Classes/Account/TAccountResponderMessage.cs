using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// IceWarp account auto responder message.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountResponderMessage">https://www.icewarp.co.uk/api/#TAccountResponderMessage</see></para>
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

        /// <inheritdoc />
        public TAccountResponderMessage()
        {
        }

        /// <inheritdoc />
        public TAccountResponderMessage(XmlNode node)
        {
            if (node != null)
            {
                From = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => From)));
                Subject = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Subject)));
                Text = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Text)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => From), From);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Subject), Subject);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Text), Text);

            return element;
        }
    }
}
