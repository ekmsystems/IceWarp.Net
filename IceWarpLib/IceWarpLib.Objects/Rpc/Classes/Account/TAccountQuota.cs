using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Account Quota
    /// </summary>
    public class TAccountQuota : TPropertyVal
    {
        /// <summary>
        /// Actual size of IceWarp account
        /// </summary>
        public int MailboxSize { get; set; }
        /// <summary>
        /// Size limit of IceWarp account
        /// </summary>
        public int MailboxQuota { get; set; }
        
        public TAccountQuota() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountQuota(XmlNode node)
        {
            if (node != null)
            {
                MailboxSize = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("MailboxSize"));
                MailboxQuota = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("MailboxQuota"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "MailboxSize", MailboxSize);
            XmlHelper.AppendTextElement(element, "MailboxQuota", MailboxQuota);
            return element;
        }
    }
}
