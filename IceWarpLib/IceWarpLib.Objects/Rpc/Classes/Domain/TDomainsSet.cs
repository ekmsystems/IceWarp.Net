using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Domain
{
    /// <summary>
    /// This class represents set of domains it may be list, single item, or even wildcard, or even negation.
    /// <para><see href="https://www.icewarp.co.uk/api/#TDomainsSet">https://www.icewarp.co.uk/api/#TDomainsSet</see></para>
    /// </summary>
    public class TDomainsSet : RpcBaseClass
    {
        /// <summary>
        /// List Of TDomainSpec. See <see cref="TDomainSpec"/> for more information.
        /// </summary>
        public List<TDomainSpec> Items { get; set; }

        /// <inheritdoc />
        public TDomainsSet()
        {
            Items = new List<TDomainSpec>();
        }

        /// <inheritdoc />
        public TDomainsSet(XmlNode node)
        {
            Items = new List<TDomainSpec>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TDomainSpec(item));
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
