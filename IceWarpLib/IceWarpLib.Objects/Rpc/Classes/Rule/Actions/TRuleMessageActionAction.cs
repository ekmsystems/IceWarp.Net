using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Simple action with the message (accept, delete, reject, spam, quarantine).
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleMessageActionAction">https://www.icewarp.co.uk/api/#TRuleMessageActionAction</see></para>
    /// </summary>
    public class TRuleMessageActionAction : TRuleAction
    {
        /// <summary>
        /// Type of the message action
        /// </summary>
        public TRuleMessageActionType MessageActionType { get; set; }

        /// <inheritdoc />
        public TRuleMessageActionAction()
        {
            Actiontype = TRuleActionType.MessageAction;
        }

        /// <inheritdoc />
        public TRuleMessageActionAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MessageActionType = (TRuleMessageActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MessageActionType)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MessageActionType), MessageActionType);

            return element;
        }
    }
}
