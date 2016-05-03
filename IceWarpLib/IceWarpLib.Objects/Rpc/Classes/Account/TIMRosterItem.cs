using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Instant messaging roster item.
    /// <para><see href="https://www.icewarp.co.uk/api/#TIMRosterItem">https://www.icewarp.co.uk/api/#TIMRosterItem</see></para>
    /// </summary>
    public class TIMRosterItem : RpcBaseClass
    {
        /// <summary>
        /// Item name
        /// </summary>
        public string Val { get; set; }
        /// <summary>
        /// Item group title
        /// </summary>
        public string GroupTitle { get; set; }

        /// <inheritdoc />
        public TIMRosterItem()
        {
        }

        /// <inheritdoc />
        public TIMRosterItem(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Val)));
                GroupTitle = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => GroupTitle)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Val), Val);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => GroupTitle), GroupTitle);

            return element;
        }
    }
}
