using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// IceWarp account auto responder settings
    /// </summary>
    public class TAccountResponder : TPropertyVal
    {
        /// <summary>
        /// List of recipients, you do not want to auto respond
        /// </summary>
        public TPropertyStringList NoRespond { get; set; }
        /// <summary>
        /// Responder message
        /// </summary>
        public TAccountResponderMessage ResponderMessage { get; set; }
        /// <summary>
        /// Type of responder
        /// </summary>
        public TResponder ResponderType { get; set; }
        /// <summary>
        /// Responder period
        /// </summary>
        public int RespondPeriod { get; set; }
        /// <summary>
        /// Respond only if between from
        /// </summary>
        public string RespondBetweenFrom { get; set; }
        /// <summary>
        /// Respond only if between to
        /// </summary>
        public string RespondBetweenTo { get; set; }
        /// <summary>
        /// Respond to messages sent only to account's email address
        /// </summary>
        public bool RespondOnlyIfToMe { get; set; }
        
        public TAccountResponder()
        {
            NoRespond = new TPropertyStringList();
            ResponderMessage = new TAccountResponderMessage();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountResponder(XmlNode node)
        {
            if (node != null)
            {
                NoRespond = new TPropertyStringList(node.GetSingleNode("NoRespond"));
                ResponderMessage = new TAccountResponderMessage(node.GetSingleNode("ResponderMessage"));
                ResponderType = (TResponder)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("ResponderType"));
                RespondPeriod = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RespondPeriod"));
                RespondBetweenFrom = Extensions.GetNodeInnerText(node.GetSingleNode("RespondBetweenFrom"));
                RespondBetweenTo = Extensions.GetNodeInnerText(node.GetSingleNode("RespondBetweenTo"));
                RespondOnlyIfToMe = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("RespondOnlyIfToMe"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            element.AppendChild(NoRespond.BuildXmlElement(doc, "NoRespond"));
            element.AppendChild(ResponderMessage.BuildXmlElement(doc, "ResponderMessage"));
            XmlHelper.AppendTextElement(element, "ResponderType", ResponderType);
            XmlHelper.AppendTextElement(element, "RespondPeriod", RespondPeriod);
            XmlHelper.AppendTextElement(element, "RespondBetweenFrom", RespondBetweenFrom);
            XmlHelper.AppendTextElement(element, "RespondBetweenTo", RespondBetweenTo);
            XmlHelper.AppendTextElement(element, "RespondOnlyIfToMe", RespondOnlyIfToMe);

            return element;
        }
    }
}
