using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Used to filter the list of services in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceListFilter">https://www.icewarp.co.uk/api/#TServiceListFilter</see></para>
    /// </summary>
    public class TServiceListFilter : RpcBaseClass
    {
        /// <summary>
        /// Not yet supported - returns all services by now
        /// </summary>
        public string Mask { get; set; }
        
        /// <inheritdoc />
        public TServiceListFilter() { }

        /// <inheritdoc />
        public TServiceListFilter(XmlNode node)
        {
            if (node != null)
            {
                Mask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Mask)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Mask), Mask);
            return element;
        }
    }
}
