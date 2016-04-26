using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Instant messaging roster item
    /// </summary>
    public class TIMRosterItem : BaseClass
    {
        /// <summary>
        /// Item name
        /// </summary>
        public string Val { get; set; }
        /// <summary>
        /// Item group title
        /// </summary>
        public string GroupTitle { get; set; }
        
        public TIMRosterItem()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TIMRosterItem(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode("Val"));
                GroupTitle = Extensions.GetNodeInnerText(node.GetSingleNode("GroupTitle"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Val", Val);
            XmlHelper.AppendTextElement(element, "GroupTitle", GroupTitle);

            return element;
        }
    }
}
