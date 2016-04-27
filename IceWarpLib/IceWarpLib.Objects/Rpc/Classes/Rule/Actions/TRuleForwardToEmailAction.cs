using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that forwards an email.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleForwardToEmailAction">https://www.icewarp.co.uk/api/#TRuleForwardToEmailAction</see></para>
    /// </summary>
    public class TRuleForwardToEmailAction : TRuleAction
    {
        /// <summary>
        /// Email the message will be forwarded to
        /// </summary>
        public string Email { get; set; }

        /// <inheritdoc />
        public TRuleForwardToEmailAction()
        {
            Actiontype = TRuleActionType.Forward;
        }

        /// <inheritdoc />
        public TRuleForwardToEmailAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Email = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Email)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Email), Email);

            return element;
        }
    }
}
