using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Activation key class.
    /// <para><see href="https://www.icewarp.co.uk/api/#TActivationKey">https://www.icewarp.co.uk/api/#TActivationKey</see></para>
    /// </summary>
    public class TActivationKey : TPropertyVal
    {
        /// <summary>
        /// Type of activation key
        /// </summary>
        public TActivationKeyType KeyType { get; set; }
        /// <summary>
        /// Key description ( will be in the email sent to user )
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Count of available activations
        /// </summary>
        public string Count { get; set; }
        /// <summary>
        /// The key string value
        /// </summary>
        public string Value { get; set; }

        /// <inheritdoc />
        public TActivationKey()
        {
        }

        /// <inheritdoc />
        public TActivationKey(XmlNode node)
        {
            if (node != null)
            {
                KeyType = (TActivationKeyType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => KeyType)));
                Description = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Description)));
                Count = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Count)));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Value)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => KeyType), KeyType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Description), Description);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Count), Count);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Value), Value);

            return element;
        }
    }
}
