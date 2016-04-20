using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Enums;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Activation key class
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
        
        public TActivationKey()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TActivationKey(XmlNode node)
        {
            if (node != null)
            {
                KeyType = (TActivationKeyType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("KeyType"));
                Description = Extensions.GetNodeInnerText(node.GetSingleNode("Description"));
                Count = Extensions.GetNodeInnerText(node.GetSingleNode("Count"));
                Value = Extensions.GetNodeInnerText(node.GetSingleNode("Value"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "KeyType", KeyType);
            XmlHelper.AppendTextElement(element, "Description", Description);
            XmlHelper.AppendTextElement(element, "Count", Count);
            XmlHelper.AppendTextElement(element, "Value", Value);

            return element;
        }
    }
}
