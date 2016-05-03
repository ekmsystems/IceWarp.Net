using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Webclient
{
    /// <summary>
    /// Represents the item in web client settings resource.
    /// <para><see href="https://www.icewarp.co.uk/api/#TWebmailSettingItem">https://www.icewarp.co.uk/api/#TWebmailSettingItem</see></para>
    /// </summary>
    public class TWebmailSettingItem : RpcBaseClass
    {
        /// <summary>
        /// Access level for domain administrator accounts
        /// </summary>
        public TWebmailSettingAccessLevel DomainAdminAccessLevel { get; set; }
        /// <summary>
        /// Access level for user accounts
        /// </summary>
        public TWebmailSettingAccessLevel UserAccessLevel { get; set; }
        /// <summary>
        /// Access level for currently logged account
        /// </summary>
        public TWebmailSettingAccessLevel AccessLevel { get; set; }
        /// <summary>
        /// Item name in selected webclient resource
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Item value in selected webclient resource
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc />
        public TWebmailSettingItem()
        {
        }

        /// <inheritdoc />
        public TWebmailSettingItem(XmlNode node) : base(node)
        {
            if (node != null)
            {
                DomainAdminAccessLevel = (TWebmailSettingAccessLevel)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => DomainAdminAccessLevel)));
                UserAccessLevel = (TWebmailSettingAccessLevel)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => UserAccessLevel)));
                AccessLevel = (TWebmailSettingAccessLevel)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => AccessLevel)));
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Value)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DomainAdminAccessLevel), DomainAdminAccessLevel);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => UserAccessLevel), UserAccessLevel);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AccessLevel), AccessLevel);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Value), Value);
            return element;
        }
    }
}
