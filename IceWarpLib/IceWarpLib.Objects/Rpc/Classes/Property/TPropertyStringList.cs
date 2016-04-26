using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents api property of type string list
    /// </summary>
    public class TPropertyStringList : TPropertyVal
    {
        /// <summary>
        /// List Of strings.
        /// </summary>
        public List<string> Val { get; set; }
        
        public TPropertyStringList()
        {
            Val = new List<string>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyStringList(XmlNode node)
        {
            Val = new List<string>();

            if (node != null)
            {
                var val = node.GetSingleNode("Val");
                if (val != null)
                {
                    var items = val.GetNodes("item");
                    if (items != null)
                    {
                        foreach (XmlNode item in items)
                        {
                            Val.Add(item.InnerText);
                        }
                    }
                }
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            var valElement = XmlHelper.CreateElement(doc, "Val");
            foreach (var item in Val)
            {
                XmlHelper.AppendTextElement(valElement, "item", item);
            }
            element.AppendChild(valElement);

            return element;
        }
    }
}
