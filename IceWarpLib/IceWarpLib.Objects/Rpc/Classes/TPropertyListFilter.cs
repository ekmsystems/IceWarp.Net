using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Used to filter the list of properties in server / domain / account API console
    /// </summary>
    public class TPropertyListFilter : BaseClass
    {
        /// <summary>
        /// Supports wildcards, used agains property name , value and comment
        /// </summary>
        public string Mask { get; set; }
        /// <summary>
        /// If the group list is specified, only properties in the group list is returned
        /// </summary>
        public TPropertyStringList Groups { get; set; }
        /// <summary>
        /// Specifies if the cached property list should be cleared or not
        /// </summary>
        public bool Clear { get; set; }
        
        public TPropertyListFilter(){ }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyListFilter(XmlNode node)
        {
            if (node != null)
            {
                Mask = Extensions.GetNodeInnerText(node.GetSingleNode("Mask"));
                Groups = new TPropertyStringList(node.GetSingleNode("Groups"));
                Clear = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Clear"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Mask", Mask);
            if (Groups != null)
            {
                element.AppendChild(Groups.BuildXmlElement(doc, "Groups"));
            }
            XmlHelper.AppendTextElement(element, "Clear", Clear);

            return element;
        }
    }
}
