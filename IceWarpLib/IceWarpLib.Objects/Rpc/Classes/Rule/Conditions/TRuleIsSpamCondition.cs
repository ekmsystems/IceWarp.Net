using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Is spam condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleIsSpamCondition">https://www.icewarp.co.uk/api/#TRuleIsSpamCondition</see></para>
    /// </summary>
    public class TRuleIsSpamCondition : TRuleCondition
    {
        /// <inheritdoc />
        public TRuleIsSpamCondition()
        {
            ConditionType = TRuleConditionType.Spam;
        }

        /// <inheritdoc />
        public TRuleIsSpamCondition(XmlNode node)
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
