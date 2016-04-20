using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Enums;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Basic informations about IceWarp account object, is used in account listing
    /// </summary>
    public class TAccountInfo : BaseClass
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
        
        public TAccountInfo()
        {
            Quota = new TAccountQuota();
            Image = new TAccountImage();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
                Email = Extensions.GetNodeInnerText(node.GetSingleNode("Email"));
                AccountType = (AccountType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("AccountType"));
                AdminType = (TAdminType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("AdminType"));
                Quota = new TAccountQuota(node.GetSingleNode("Quota"));
                Image = new TAccountImage(node.GetSingleNode("Image"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "Name", Name);
            XmlHelper.AppendTextElement(element, "Email", Email);
            XmlHelper.AppendTextElement(element, "AccountType", AccountType);
            XmlHelper.AppendTextElement(element, "AdminType", AdminType);
            element.AppendChild(Quota.BuildXmlElement(doc, "Quota"));
            element.AppendChild(Image.BuildXmlElement(doc, "Image"));
            
            return element;
        }
    }
}
