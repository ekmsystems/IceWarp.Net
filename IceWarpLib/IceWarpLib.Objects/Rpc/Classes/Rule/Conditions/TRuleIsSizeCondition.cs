using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Is Size condition type
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
        public TRuleIsSizeCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleIsSizeCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                CompareType = (TRuleCompareType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("CompareType"));
                Size = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Size"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "CompareType", CompareType);
            XmlHelper.AppendTextElement(element, "Size", Size);

            return element;
        }
    }
}
