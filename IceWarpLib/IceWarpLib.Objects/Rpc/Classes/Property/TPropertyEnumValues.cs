using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// List of property enumeration values.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyEnumValues">https://www.icewarp.co.uk/api/#TPropertyEnumValues</see></para>
    /// </summary>
    public class TPropertyEnumValues : RpcBaseClass
    {
        /// <summary>
        /// List of property enumeration values. See <see cref="TPropertyEnumValue"/> for more information.
        /// </summary>
        public List<TPropertyEnumValue> Items { get; set; }

        /// <inheritdoc />
        public TPropertyEnumValues()
        {
            Items = new List<TPropertyEnumValue>();
        }

        /// <inheritdoc />
        public TPropertyEnumValues(XmlNode node)
        {
            Items = new List<TPropertyEnumValue>();

            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyEnumValue(item));
                    }
                }
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, XmlHelper.ItemTag));
            }

            return element;
        }
    }
}
