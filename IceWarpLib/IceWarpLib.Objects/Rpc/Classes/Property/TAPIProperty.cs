using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents property of server, domain, account, mobile device or statistic object.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAPIProperty">https://www.icewarp.co.uk/api/#TAPIProperty</see></para>
    /// </summary>
    public class TAPIProperty : RpcBaseClass
    {
        /// <summary>
        /// Property name as in apiconst.dat
        /// </summary>
        public string PropName { get; set; }

        /// <inheritdoc />
        public TAPIProperty() { }

        /// <inheritdoc />
        public TAPIProperty(XmlNode node)
        {
            if (node != null)
            {
                PropName = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => PropName)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PropName), PropName);
            return element;
        }
    }
}
