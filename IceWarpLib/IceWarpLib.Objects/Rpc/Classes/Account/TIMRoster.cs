using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// API Property representing Instant messaging roster list.
    /// <para><see href="https://www.icewarp.co.uk/api/#TIMRoster">https://www.icewarp.co.uk/api/#TIMRoster</see></para>
    /// </summary>
    public class TIMRoster : TPropertyVal
    {
        /// <summary>
        /// Instant messaging roster list
        /// </summary>
        public TIMRosterList Val { get; set; }

        /// <inheritdoc />
        public TIMRoster()
        {
            Val = new TIMRosterList();
        }

        /// <inheritdoc />
        public TIMRoster(XmlNode node)
        {
            if (node != null)
            {
                Val = new TIMRosterList(node.GetSingleNode(ClassHelper.GetMemberName(() => Val)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            element.AppendChild(Val.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Val)));

            return element;
        }
    }
}
