using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes
{
    public class TRuleSenderRecipientCondition : TRuleCondition
    {
        /// <summary>
        /// Recipient or Sender condition
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

        public TRuleSenderRecipientCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSenderRecipientCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                RecipientSender = (TRuleRecipientSenderType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RecipientSender"));
                RemoteLocal = (TRuleRemoteLocalType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RemoteLocal"));
                RecipientCondition = (TRuleRecipientConditionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RecipientCondition"));
                Account = Extensions.GetNodeInnerText(node.GetSingleNode("Account"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "RecipientSender", RecipientSender);
            XmlHelper.AppendTextElement(element, "RemoteLocal", RemoteLocal);
            XmlHelper.AppendTextElement(element, "RecipientCondition", RecipientCondition);
            XmlHelper.AppendTextElement(element, "Account", Account);

            return element;
        }
    }
}
