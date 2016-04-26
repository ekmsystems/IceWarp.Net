using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// List of rule conditions
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <item>
    ///             <classname>truletrustedsessioncondition</classname>
    ///         </item>
    ///         <item>
    ///         <classname>trulednsblcondition</classname>
    ///         <server>stringval</server>
    ///         <regex>stringval</regex>
    ///         </item>
    ///     </custom>
    /// </code>
    public class TRuleConditions : BaseClass
    {
        /// <summary>
        /// List Of TRuleCondition. See <see cref="TRuleCondition"/> for more information.
        /// </summary>
        public List<TRuleCondition> Items { get; set; }
        
        public TRuleConditions()
        {
            Items = new List<TRuleCondition>();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleConditions(XmlNode node)
        {
            Items = new List<TRuleCondition>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    var className = Extensions.GetNodeInnerText(item.GetSingleNode("ClassName"));
                    if (!String.IsNullOrEmpty(className))
                    {
                        var classType = ClassHelper.TRuleConditionClasses()
                                                   .FirstOrDefault(x => x.ClassName.ToLower() == className.ToLower());
                        if (classType != null)
                        {
                            Items.Add((TRuleCondition)ClassHelper.GetInstance(classType.AssemblyQualifiedName, new[] { item }));
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
