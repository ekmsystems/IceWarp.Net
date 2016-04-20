using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Used to specify properties of IceWarp domain ( by property name )
    /// </summary>
    public class TDomainPropertyList : BaseClass
    {
        /// <summary>
        /// List Of TAPIProperty. See <see cref="TAPIProperty"/> for more information.
        /// </summary>
        public List<TAPIProperty> Items { get; set; }
        
        public TDomainPropertyList()
        {
            Items = new List<TAPIProperty>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainPropertyList(XmlNode node)
        {
            Items = new List<TAPIProperty>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TAPIProperty(item));
                }
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, "item"));
            }

            return element;
        }
    }
}
