using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents the account member list ( mailing list, group )
    /// </summary>
    public class TPropertyMembers : TPropertyVal
    {
        /// <summary>
        /// List Of TPropertyMember. See <see cref="TPropertyMember"/> for more information.
        /// </summary>
        public List<TPropertyMember> Val { get; set; }
        
        public TPropertyMembers()
        {
            Val = new List<TPropertyMember>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TPropertyMembers(XmlNode node)
        {
            Val = new List<TPropertyMember>();
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
                            Val.Add(new TPropertyMember(item));
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
                valElement.AppendChild(item.BuildXmlElement(doc, "item"));
            }
            element.AppendChild(valElement);

            return element;
        }
    }
}
