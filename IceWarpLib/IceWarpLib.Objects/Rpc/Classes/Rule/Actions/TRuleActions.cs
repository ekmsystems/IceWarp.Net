using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// List of rule actions
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <item>
    ///           <classname>truleforwardtoemailaction</classname>
    ///           <email>stringval</email>
    ///         </item>
    ///         <item>
    ///           <classname>trulemessageactionaction</classname>
    ///           <messageactiontype>enumval</messageactiontype>
    ///         </item>
    ///     </custom>
    /// </code>
    public class TRuleActions : BaseClass
    {
        /// <summary>
        /// List Of TRuleAction. See <see cref="TRuleAction"/> for more information.
        /// </summary>
        public List<TRuleAction> Items { get; set; }
        
        public TRuleActions()
        {
            Items = new List<TRuleAction>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleActions(XmlNode node)
        {
            Items = new List<TRuleAction>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    var className = Extensions.GetNodeInnerText(item.GetSingleNode("ClassName"));
                    if (!String.IsNullOrEmpty(className))
                    {
                        var classType = ClassHelper.TRuleActionClasses()
                                                   .FirstOrDefault(x => x.ClassName.ToLower() == className.ToLower());
                        if (classType != null)
                        {
                            Items.Add((TRuleAction)ClassHelper.GetInstance(classType.AssemblyQualifiedName, new[] { item }));
                        }
                    }
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
