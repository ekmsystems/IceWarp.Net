using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Has attachment condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleHasAttachmentCondition">https://www.icewarp.co.uk/api/#TRuleHasAttachmentCondition</see></para>
    /// </summary>
    public class TRuleHasAttachmentCondition : TRuleCondition
    {
        /// <inheritdoc />
        public TRuleHasAttachmentCondition()
        {
            ConditionType = TRuleConditionType.HasAttach;
        }

        /// <inheritdoc />
        public TRuleHasAttachmentCondition(XmlNode node)
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
