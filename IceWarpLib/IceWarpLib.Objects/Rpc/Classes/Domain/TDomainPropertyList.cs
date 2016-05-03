using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// Used to specify properties of IceWarp domain ( by property name ).
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainPropertyList">https://www.icewarp.co.uk/api/#TDomainPropertyList</see></para>
    /// </summary>
    public class TDomainPropertyList : RpcBaseClass
    {
        /// <summary>
        /// List Of TAPIProperty. See <see cref="TAPIProperty"/> for more information.
        /// </summary>
        public List<TAPIProperty> Items { get; set; }

        /// <inheritdoc />
        public TDomainPropertyList()
        {
            Items = new List<TAPIProperty>();
        }

        /// <inheritdoc />
        public TDomainPropertyList(XmlNode node)
        {
            Items = new List<TAPIProperty>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TAPIProperty(item));
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
