using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Item that represents header modification.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleEditHeaderItem">https://www.icewarp.co.uk/api/#TRuleEditHeaderItem</see></para>
    /// </summary>
    public class TRuleEditHeaderItem : RpcBaseClass
    {
        /// <summary>
        /// Type of action
        /// </summary>
        public TRuleEditHeaderType EditHeaderType { get; set; }
        /// <summary>
        /// Header name
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// If uses regex
        /// </summary>
        public bool HasRegex { get; set; }
        /// <summary>
        /// Regex value
        /// </summary>
        public string Regex { get; set; }
        /// <summary>
        /// Header value
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc />
        public TRuleEditHeaderItem() { }

        /// <inheritdoc />
        public TRuleEditHeaderItem(XmlNode node)
        {
            if (node != null)
            {
                EditHeaderType = (TRuleEditHeaderType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => EditHeaderType)));
                Header = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Header)));
                HasRegex = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => HasRegex)));
                Regex = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Regex)));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Value)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => EditHeaderType), EditHeaderType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Header), Header);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HasRegex), HasRegex);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Regex), Regex);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Value), Value);

            return element;
        }
    }
}
