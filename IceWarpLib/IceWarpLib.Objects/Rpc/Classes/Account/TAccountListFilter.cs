using System.Xml;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Used to filter the list of accounts in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountListFilter">https://www.icewarp.co.uk/api/#TAccountListFilter</see></para>
    /// </summary>
    public class TAccountListFilter : RpcBaseClass
    {
        /// <summary>
        /// Mask that is used agains account name and alias
        /// </summary>
        public string NameMask { get; set; }
        /// <summary>
        /// Mask that is used agains account type
        /// </summary>
        public AccountType? TypeMask { get; set; }

        /// <inheritdoc />
        public TAccountListFilter() { }

        /// <inheritdoc />
        public TAccountListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => NameMask)));
                TypeMask = (AccountType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => TypeMask)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => NameMask), NameMask);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => TypeMask), TypeMask);
            return element;
        }
    }
}
