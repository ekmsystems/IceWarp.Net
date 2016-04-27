using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Full name of IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountName">https://www.icewarp.co.uk/api/#TAccountName</see></para>
    /// </summary>
    public class TAccountName : TPropertyVal
    {
        /// <summary>
        /// Account name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account surname
        /// </summary>
        public string Surname { get; set; }

        /// <inheritdoc />
        public TAccountName()
        {
        }

        /// <inheritdoc />
        public TAccountName(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                Surname = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Surname)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Surname), Surname);

            return element;
        }
    }
}
