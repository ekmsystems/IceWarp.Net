using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// List of services traffic data
    /// <para><see href="https://www.icewarp.co.uk/api/#TSCItmList">https://www.icewarp.co.uk/api/#TSCItmList</see></para>
    /// </summary>
    public class TSCItmList : RpcBaseClass
    {
        /// <summary>
        /// List Of TSCItm. See <see cref="TSCItm"/>
        /// </summary>
        public List<TSCItm> Items { get; set; }

        /// <inheritdoc />
        public TSCItmList()
        {
            Items = new List<TSCItm>();
        }

        /// <inheritdoc />
        public TSCItmList(XmlNode node) : base(node)
        {
            Items = new List<TSCItm>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TSCItm(item));
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
