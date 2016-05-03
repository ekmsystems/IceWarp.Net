using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// This class represents a domain, or domain pattern using wildcards.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainSpec">https://www.icewarp.co.uk/api/#TDomainSpec</see></para>
    /// </summary>
    public class TDomainSpec : RpcBaseClass
    {
        /// <summary>
        /// Domain name or pattern
        /// </summary>
        public string Mask { get; set; }
        /// <summary>
        /// Negates the Mask
        /// </summary>
        public bool Negate { get; set; }

        /// <inheritdoc />
        public TDomainSpec()
        {
        }

        /// <inheritdoc />
        public TDomainSpec(XmlNode node)
        {
            if (node != null)
            {
                Mask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Mask)));
                Negate = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Negate)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Mask), Mask);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Negate), Negate);

            return element;
        }
    }
}
