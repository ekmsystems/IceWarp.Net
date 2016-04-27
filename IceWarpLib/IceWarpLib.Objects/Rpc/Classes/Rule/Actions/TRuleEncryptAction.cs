using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that encrypts the message.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleEncryptAction">https://www.icewarp.co.uk/api/#TRuleEncryptAction</see></para>
    /// </summary>
    public class TRuleEncryptAction : TRuleAction
    {
        /// <inheritdoc />
        public TRuleEncryptAction()
        {
            Actiontype = TRuleActionType.Encrypt;
        }

        /// <inheritdoc />
        public TRuleEncryptAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);

            return element;
        }
    }
}
