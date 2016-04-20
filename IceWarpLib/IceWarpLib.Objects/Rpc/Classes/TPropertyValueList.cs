using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Represents class TPropertyValueList
    /// </summary>
    public class TPropertyValueList : BaseClass
    {
        /// <summary>
        /// List Of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        public List<TPropertyValue> Items { get; set; }
        
        public TPropertyValueList()
        {
            Items = new List<TPropertyValue>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyValueList(XmlNode node)
        {
            Items = new List<TPropertyValue>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyValue(item));
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
