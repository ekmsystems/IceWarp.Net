using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// SQL condition type All messages condition.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleAllCondition">https://www.icewarp.co.uk/api/#TRuleAllCondition</see></para>
    /// </summary>
    public class TRuleAllCondition : TRuleCondition
    {
        /// <inheritdoc />
        public TRuleAllCondition()
        {
            ConditionType = TRuleConditionType.All;
        }

        /// <inheritdoc />
        public TRuleAllCondition(XmlNode node)
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
