using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Rule action that sends a message.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSendMessageAction">https://www.icewarp.co.uk/api/#TRuleSendMessageAction</see></para>
    /// </summary>
    public class TRuleSendMessageAction : TRuleAction
    {
        /// <summary>
        /// Message From
        /// </summary>
        public string MessageFrom { get; set; }
        /// <summary>
        /// Message To
        /// </summary>
        public string MessageTo { get; set; }
        /// <summary>
        /// Message Subject
        /// </summary>
        public string MessageSubject { get; set; }
        /// <summary>
        /// Message Text body
        /// </summary>
        public string MessageText { get; set; }

        /// <inheritdoc />
        public TRuleSendMessageAction()
        {
            Actiontype = TRuleActionType.SendMessage;
        }

        /// <inheritdoc />
        public TRuleSendMessageAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MessageFrom = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MessageFrom)));
                MessageTo = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MessageTo)));
                MessageSubject = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MessageSubject)));
                MessageText = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MessageText)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MessageFrom), MessageFrom);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MessageTo), MessageTo);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MessageSubject), MessageSubject);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MessageText), MessageText);

            return element;
        }
    }
}
