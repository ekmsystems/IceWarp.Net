using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// List of rule actions.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleActions">https://www.icewarp.co.uk/api/#TRuleActions</see></para>
    /// </summary>
    public class TRuleActions : RpcBaseClass
    {
        /// <summary>
        /// List Of TRuleAction. See <see cref="TRuleAction"/> for more information.
        /// </summary>
        public List<TRuleAction> Items { get; set; }

        /// <inheritdoc />
        public TRuleActions()
        {
            Items = new List<TRuleAction>();
        }

        /// <inheritdoc />
        public TRuleActions(XmlNode node)
        {
            Items = new List<TRuleAction>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    var className = Extensions.GetNodeInnerText(item.GetSingleNode(XmlHelper.ClassNameTag));
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
