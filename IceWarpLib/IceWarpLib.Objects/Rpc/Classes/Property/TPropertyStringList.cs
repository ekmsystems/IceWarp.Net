using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents api property of type string list.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyStringList">https://www.icewarp.co.uk/api/#TPropertyStringList</see></para>
    /// </summary>
    public class TPropertyStringList : TPropertyVal
    {
        /// <summary>
        /// List Of strings.
        /// </summary>
        public List<string> Val { get; set; }

        /// <inheritdoc />
        public TPropertyStringList()
        {
            Val = new List<string>();
        }

        /// <inheritdoc />
        public TPropertyStringList(XmlNode node)
        {
            Val = new List<string>();

            if (node != null)
            {
                var val = node.GetSingleNode(ClassHelper.GetMemberName(() => Val));
                if (val != null)
                {
                    var items = val.GetNodes(XmlHelper.ItemTag);
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

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            var valElement = XmlHelper.CreateElement(doc, ClassHelper.GetMemberName(() => Val));
            foreach (var item in Val)
            {
                XmlHelper.AppendTextElement(valElement, XmlHelper.ItemTag, item);
            }
            element.AppendChild(valElement);

            return element;
        }
    }
}
