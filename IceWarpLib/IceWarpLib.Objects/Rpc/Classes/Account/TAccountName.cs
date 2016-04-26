using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Full name of IceWarp account
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
        
        public TAccountName()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TAccountName(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
                Surname = Extensions.GetNodeInnerText(node.GetSingleNode("Surname"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Name", Name);
            XmlHelper.AppendTextElement(element, "Surname", Surname);

            return element;
        }
    }
}
