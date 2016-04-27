using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents the account member list ( mailing list, group ).
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyMembers">https://www.icewarp.co.uk/api/#TPropertyMembers</see></para>
    /// </summary>
    public class TPropertyMembers : TPropertyVal
    {
        /// <summary>
        /// List Of TPropertyMember. See <see cref="TPropertyMember"/> for more information.
        /// </summary>
        public List<TPropertyMember> Val { get; set; }

        /// <inheritdoc />
        public TPropertyMembers()
        {
            Val = new List<TPropertyMember>();
        }

        /// <inheritdoc />
        public TPropertyMembers(XmlNode node)
        {
            Val = new List<TPropertyMember>();
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
                            Val.Add(new TPropertyMember(item));
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
                valElement.AppendChild(item.BuildXmlElement(doc, XmlHelper.ItemTag));
            }
            element.AppendChild(valElement);

            return element;
        }
    }
}
