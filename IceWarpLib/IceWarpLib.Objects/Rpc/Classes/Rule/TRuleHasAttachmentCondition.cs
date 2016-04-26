using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Has attachment condition type
    /// </summary>
    public class TRuleHasAttachmentCondition : TRuleCondition
    {
        public TRuleHasAttachmentCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleHasAttachmentCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);

            return element;
        }
    }
}
