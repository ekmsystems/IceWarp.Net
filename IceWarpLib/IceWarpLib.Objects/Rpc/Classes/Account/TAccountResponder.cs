using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// IceWarp account auto responder settings.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountResponder">https://www.icewarp.co.uk/api/#TAccountResponder</see></para>
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

        /// <inheritdoc />
        public TAccountResponder()
        {
            NoRespond = new TPropertyStringList();
            ResponderMessage = new TAccountResponderMessage();
        }

        /// <inheritdoc />
        public TAccountResponder(XmlNode node)
        {
            if (node != null)
            {
                NoRespond = new TPropertyStringList(node.GetSingleNode(ClassHelper.GetMemberName(() => NoRespond)));
                ResponderMessage = new TAccountResponderMessage(node.GetSingleNode(ClassHelper.GetMemberName(() => ResponderMessage)));
                ResponderType = (TResponder)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ResponderType)));
                RespondPeriod = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RespondPeriod)));
                RespondBetweenFrom = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => RespondBetweenFrom)));
                RespondBetweenTo = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => RespondBetweenTo)));
                RespondOnlyIfToMe = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => RespondOnlyIfToMe)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            element.AppendChild(NoRespond.BuildXmlElement(doc, ClassHelper.GetMemberName(() => NoRespond)));
            element.AppendChild(ResponderMessage.BuildXmlElement(doc, ClassHelper.GetMemberName(() => ResponderMessage)));
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ResponderType), ResponderType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RespondPeriod), RespondPeriod);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RespondBetweenFrom), RespondBetweenFrom);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RespondBetweenTo), RespondBetweenTo);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RespondOnlyIfToMe), RespondOnlyIfToMe);

            return element;
        }
    }
}
