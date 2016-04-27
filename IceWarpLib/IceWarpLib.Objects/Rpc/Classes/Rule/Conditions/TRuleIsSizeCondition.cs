using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Is Size condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleIsSizeCondition">https://www.icewarp.co.uk/api/#TRuleIsSizeCondition</see></para>
    /// </summary>
    public class TRuleIsSizeCondition : TRuleCondition
    {
        /// <summary>
        /// Type of comparation
        /// </summary>
        public TRuleCompareType CompareType { get; set; }
        /// <summary>
        /// Size in bytes
        /// </summary>
        public int Size { get; set; }

        /// <inheritdoc />
        public TRuleIsSizeCondition()
        {
            ConditionType = TRuleConditionType.Size;
        }

        /// <inheritdoc />
        public TRuleIsSizeCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                CompareType = (TRuleCompareType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => CompareType)));
                Size = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Size)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CompareType), CompareType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Size), Size);

            return element;
        }
    }
}
