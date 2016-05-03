using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Used to filter the list of rules in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRulesListFilter">https://www.icewarp.co.uk/api/#TRulesListFilter</see></para>
    /// </summary>
    public class TRulesListFilter : RpcBaseClass
    {
        /// <summary>
        /// Used against rule name
        /// </summary>
        public string NameMask { get; set; }

        /// <inheritdoc />
        public TRulesListFilter() { }

        /// <inheritdoc />
        public TRulesListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => NameMask)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => NameMask), NameMask);
            return element;
        }
    }
}
