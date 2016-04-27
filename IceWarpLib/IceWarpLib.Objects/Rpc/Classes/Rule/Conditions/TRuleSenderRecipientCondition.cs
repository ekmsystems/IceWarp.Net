using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Sender Recipient condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSenderRecipientCondition">https://www.icewarp.co.uk/api/#</see></para>
    /// </summary>
    public class TRuleSenderRecipientCondition : TRuleCondition
    {
        /// <summary>
        /// Recipient or Sender condition.
        /// </summary>
        public TRuleRecipientSenderType RecipientSender { get; set; }
        /// <summary>
        /// Remote or Local condition
        /// </summary>
        public TRuleRemoteLocalType RemoteLocal { get; set; }
        /// <summary>
        /// Recipient condition
        /// </summary>
        public TRuleRecipientConditionType RecipientCondition { get; set; }
        /// <summary>
        /// Account condition value
        /// </summary>
        public string Account { get; set; }

        /// <inheritdoc />
        public TRuleSenderRecipientCondition()
        {
            ConditionType = TRuleConditionType.SenderRecipient;
        }

        /// <inheritdoc />
        public TRuleSenderRecipientCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                RecipientSender = (TRuleRecipientSenderType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RecipientSender)));
                RemoteLocal = (TRuleRemoteLocalType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RemoteLocal)));
                RecipientCondition = (TRuleRecipientConditionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RecipientCondition)));
                Account = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Account)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RecipientSender), RecipientSender);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RemoteLocal), RemoteLocal);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RecipientCondition), RecipientCondition);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Account), Account);

            return element;
        }
    }
}
