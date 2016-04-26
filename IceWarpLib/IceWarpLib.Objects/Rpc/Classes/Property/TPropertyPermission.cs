using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Defines a permissions for API property
    /// </summary>
    public class TPropertyPermission : BaseClass
    {
        /// <summary>
        /// Property ID
        /// </summary>
        public int Prop { get; set; }
        /// <summary>
        /// Property Permission. See <see cref="TPermission"/>
        /// </summary>
        public TPermission Perm { get; set; }
        
        public TPropertyPermission() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyPermission(XmlNode node)
        {
            if (node != null)
            {
                Prop = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Prop"));
                Perm = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Perm"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Prop", Prop.ToString());
            XmlHelper.AppendTextElement(element, "Perm", Perm.ToString());

            return element;
        }
    }
}
