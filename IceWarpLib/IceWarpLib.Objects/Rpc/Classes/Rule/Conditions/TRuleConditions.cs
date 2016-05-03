using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// List of rule conditions.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleConditions">https://www.icewarp.co.uk/api/#TRuleConditions</see></para>
    /// </summary>
    public class TRuleConditions : RpcBaseClass
    {
        /// <summary>
        /// List Of TRuleCondition. See <see cref="TRuleCondition"/> for more information.
        /// </summary>
        public List<TRuleCondition> Items { get; set; }

        /// <inheritdoc />
        public TRuleConditions()
        {
            Items = new List<TRuleCondition>();
        }

        /// <inheritdoc />
        public TRuleConditions(XmlNode node)
        {
            Items = new List<TRuleCondition>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    var className = Extensions.GetNodeInnerText(item.GetSingleNode(XmlHelper.ClassNameTag));
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
