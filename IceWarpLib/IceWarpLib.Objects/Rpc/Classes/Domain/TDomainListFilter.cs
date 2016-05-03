using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Used to filter the list of domains in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainListFilter">https://www.icewarp.co.uk/api/#TDomainListFilter</see></para>
    /// </summary>
    public class TDomainListFilter : RpcBaseClass
    {
        /// <summary>
        /// Used against domain name & description
        /// </summary>
        public string NameMask { get; set; }
        /// <summary>
        /// Used against domain type
        /// </summary>
        public TDomainType? TypeMask { get; set; }
        /// <summary>
        /// Returns the name of the class.
        /// </summary>
        public string ClassName { get { return this.GetType().Name.ToLower(); } }

        /// <inheritdoc />
        public TDomainListFilter() { }

        /// <inheritdoc />
        public TDomainListFilter(XmlNode node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => NameMask)));
                TypeMask = (TDomainType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => TypeMask)));
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
