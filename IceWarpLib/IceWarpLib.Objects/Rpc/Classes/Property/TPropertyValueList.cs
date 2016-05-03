using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Represents class TPropertyValueList.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyValueList">https://www.icewarp.co.uk/api/#TPropertyValueList</see></para>
    /// </summary>
    public class TPropertyValueList : RpcBaseClass
    {
        /// <summary>
        /// List Of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        public List<TPropertyValue> Items { get; set; }

        /// <inheritdoc />
        public TPropertyValueList()
        {
            Items = new List<TPropertyValue>();
        }

        /// <inheritdoc />
        public TPropertyValueList(XmlNode node)
        {
            Items = new List<TPropertyValue>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyValue(item));
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
