using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents the account member( mailing list, group )
    /// </summary>
    public class TPropertyMember : TPropertyVal
    {
        /// <summary>
        /// Name of the member
        /// </summary>
        public string Val { get; set; }
        /// <summary>
        /// Mailing list - Member will have default rights as defined within the Mailing List – Security tab of mailing list settings.
        /// </summary>
        public bool Default { get; set; }
        /// <summary>
        /// Mailing list - Member will receive all messages sent to the list and cannot post messages to the list.
        /// </summary>
        public bool Recieve { get; set; }
        /// <summary>
        /// Mailing list - Member can post message to the mailing list.
        /// </summary>
        public bool Post { get; set; }
        /// <summary>
        /// Mailing list - Member will receive all messages sent to the list, in a single "digest" message, and cannot post messages to the list.
        /// </summary>
        public bool Digest { get; set; }
        
        public TPropertyMember()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyMember(XmlNode node)
        {
            if (node != null)
            {
                Val = Extensions.GetNodeInnerText(node.GetSingleNode("Val"));
                Default = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Default"));
                Recieve = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Recieve"));
                Post = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Post"));
                Digest = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Digest"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Val", Val);
            XmlHelper.AppendTextElement(element, "Default", Default);
            XmlHelper.AppendTextElement(element, "Recieve", Recieve);
            XmlHelper.AppendTextElement(element, "Post", Post);
            XmlHelper.AppendTextElement(element, "Digest", Digest);

            return element;
        }
    }
}
