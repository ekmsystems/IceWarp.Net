using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Bayes score condition type Antivirus condition type SMTP Auth condition type
    /// </summary>
    public class TRuleSMTPAuthCondition : TRuleCondition
    {
        public TRuleSMTPAuthCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSMTPAuthCondition(XmlNode node)
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
