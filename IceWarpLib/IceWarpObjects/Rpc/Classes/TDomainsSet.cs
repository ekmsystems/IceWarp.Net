using System.Collections.Generic;
using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// This class represents set of domains it may be list, single item, or even wildcard, or even negation
    /// </summary>
    public class TDomainsSet : BaseClass
    {
        /// <summary>
        /// List Of TDomainSpec. See <see cref="TDomainSpec"/> for more information.
        /// </summary>
        public List<TDomainSpec> Items { get; set; }

        public TDomainsSet()
        {
            Items = new List<TDomainSpec>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TDomainsSet(XmlNode node)
        {
            Items = new List<TDomainSpec>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TDomainSpec(item));
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
