using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Account Quota.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountQuota">https://www.icewarp.co.uk/api/#TAccountQuota</see></para>
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

        /// <inheritdoc />
        public TAccountQuota() { }

        /// <inheritdoc />
        public TAccountQuota(XmlNode node)
        {
            if (node != null)
            {
                MailboxSize = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MailboxSize)));
                MailboxQuota = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MailboxQuota)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MailboxSize), MailboxSize);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MailboxQuota), MailboxQuota);
            return element;
        }
    }
}
