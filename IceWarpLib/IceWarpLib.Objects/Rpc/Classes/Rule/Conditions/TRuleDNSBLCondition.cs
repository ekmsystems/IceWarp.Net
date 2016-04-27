using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// RFC822 condition type Application condition type DNSBL server condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleDNSBLCondition">https://www.icewarp.co.uk/api/#TRuleDNSBLCondition</see></para>
    /// </summary>
    public class TRuleDNSBLCondition : TRuleCondition
    {
        /// <summary>
        /// Server value
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Regex value
        /// </summary>
        public string Regex { get; set; }

        /// <inheritdoc />
        public TRuleDNSBLCondition()
        {
            ConditionType = TRuleConditionType.DNSBL;
        }

        /// <inheritdoc />
        public TRuleDNSBLCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Server = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Server)));
                Regex = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Regex)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Server), Server);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Regex), Regex);

            return element;
        }
    }
}
