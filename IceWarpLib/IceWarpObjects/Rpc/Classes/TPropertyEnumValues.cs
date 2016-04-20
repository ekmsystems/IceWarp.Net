using System.Collections.Generic;
using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// List of property enumeration values. See <see cref="TPropertyEnumValue"/> for more information.
    /// </summary>
    public class TPropertyEnumValues : BaseClass
    {
        /// <summary>
        /// List of property enumeration values. See <see cref="TPropertyEnumValue"/> for more information.
        /// </summary>
        public List<TPropertyEnumValue> Items { get; set; }
        
        public TPropertyEnumValues()
        {
            Items = new List<TPropertyEnumValue>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyEnumValues(XmlNode node)
        {
            Items = new List<TPropertyEnumValue>();

            if (node != null)
            {
                var items = node.GetNodes("item");
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyEnumValue(item));
                    }
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
