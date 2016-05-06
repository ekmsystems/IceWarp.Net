using System.Xml;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Basic informations about IceWarp account object, is used in account listing.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountInfo">https://www.icewarp.co.uk/api/#TAccountInfo</see></para>
    /// </summary>
    public class TAccountInfo : RpcBaseClass
    {
        /// <summary>
        /// Account full name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Type of the account
        /// </summary>
        public AccountType AccountType { get; set; }
        /// <summary>
        /// Type of account permissions
        /// </summary>
        public TAdminType AdminType { get; set; }
        /// <summary>
        /// Account disk quota
        /// </summary>
        public TAccountQuota Quota { get; set; }
        /// <summary>
        /// Account vCard image
        /// </summary>
        public TAccountImage Image { get; set; }

        /// <inheritdoc />
        public TAccountInfo()
        {
            Quota = new TAccountQuota();
            Image = new TAccountImage();
        }

        /// <inheritdoc />
        public TAccountInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                Email = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Email)));
                AccountType = (AccountType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => AccountType)));
                AdminType = (TAdminType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => AdminType)));
                Quota = new TAccountQuota(node.GetSingleNode(ClassHelper.GetMemberName(() => Quota)));
                Image = new TAccountImage(node.GetSingleNode(ClassHelper.GetMemberName(() => Image)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Email), Email);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AccountType), AccountType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => AdminType), AdminType);
            element.AppendChild(Quota.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Quota)));
            element.AppendChild(Image.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Image)));
            
            return element;
        }
    }
}
