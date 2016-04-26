using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// API Property representing Instant messaging roster list
    /// </summary>
    public class TIMRoster : TPropertyVal
    {
        /// <summary>
        /// Instant messaging roster list
        /// </summary>
        public TIMRosterList Val { get; set; }
        
        public TIMRoster()
        {
            Val = new TIMRosterList();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TIMRoster(XmlNode node)
        {
            if (node != null)
            {
                Val = new TIMRosterList(node.GetSingleNode("Val"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            element.AppendChild(Val.BuildXmlElement(doc, "Val"));

            return element;
        }
    }
}
