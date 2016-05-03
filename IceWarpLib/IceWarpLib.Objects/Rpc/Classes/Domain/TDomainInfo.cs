using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Basic information about an IceWarp domain object.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainInfo">https://www.icewarp.co.uk/api/#TDomainInfo</see></para>
    /// </summary>
    public class TDomainInfo : RpcBaseClass
    {
        /// <summary>
        /// Domain name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Domain description
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// Domain type. See <see cref="TDomainType"/>
        /// </summary>
        public TDomainType DomainType { get; set; }
        /// <summary>
        /// Number of accounts
        /// </summary>
        public int AccountCount { get; set; }

        /// <inheritdoc />
        public TDomainInfo() { }

        /// <inheritdoc />
        public TDomainInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                Desc = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Desc)));
                DomainType = (TDomainType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainType)));
                AccountCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => AccountCount)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Desc), Desc);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DomainType), DomainType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AccountCount), AccountCount);

            return element;
        }
    }
}
