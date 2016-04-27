using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Bayes score condition type Antivirus condition type SMTP Auth condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSMTPAuthCondition">https://www.icewarp.co.uk/api/#TRuleSMTPAuthCondition</see></para>
    /// </summary>
    public class TRuleSMTPAuthCondition : TRuleCondition
    {
        /// <inheritdoc />
        public TRuleSMTPAuthCondition()
        {
            ConditionType = TRuleConditionType.SMTPAuth;
        }

        /// <inheritdoc />
        public TRuleSMTPAuthCondition(XmlNode node)
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
