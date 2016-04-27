using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Session is trusted condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleTrustedSessionCondition">https://www.icewarp.co.uk/api/#TRuleTrustedSessionCondition</see></para>
    /// </summary>
    public class TRuleTrustedSessionCondition : TRuleCondition
    {
        /// <inheritdoc />
        public TRuleTrustedSessionCondition()
        {
            ConditionType = TRuleConditionType.TrustedSession;
        }

        /// <inheritdoc />
        public TRuleTrustedSessionCondition(XmlNode node)
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
