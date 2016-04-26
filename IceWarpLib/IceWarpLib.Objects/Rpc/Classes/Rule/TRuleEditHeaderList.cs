using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// List of header modifications
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <item>
    ///             <editheadertype>enumval</editheadertype>
    ///             <header>stringval</header>
    ///             <hasregex>enumval</hasregex>
    ///             <regex>stringval</regex>
    ///             <value>stringval</value>
    ///         </item>
    ///         <item>
    ///           <editheadertype>enumval</editheadertype>
    ///           <header>stringval</header>
    ///           <hasregex>enumval</hasregex>
    ///           <regex>stringval</regex>
    ///           <value>stringval</value>
    ///         </item>
    ///     </custom>
    /// </code>
    public class TRuleEditHeaderList : BaseClass
    {
        /// <summary>
        /// List Of TRuleEditHeaderItem. <see cref="TRuleEditHeaderItem"/>
        /// </summary>
        public List<TRuleEditHeaderItem> Items { get; set; }

        public TRuleEditHeaderList()
        {
            Items = new List<TRuleEditHeaderItem>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleEditHeaderList(XmlNode node)
        {
            Items = new List<TRuleEditHeaderItem>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TRuleEditHeaderItem(item));
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
