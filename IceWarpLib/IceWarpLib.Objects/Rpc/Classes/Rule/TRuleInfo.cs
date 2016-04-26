using System;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Brief information about some rule in IceWarp server
    /// </summary>
    public class TRuleInfo : BaseClass
    {
        /// <summary>
        /// Identification number of the rule
        /// </summary>
        public string RuleID { get; set; }
        /// <summary>
        /// Rule title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Specifies if the rule is active or not
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// If there is some message action in rule, return such action ( used for icon )
        /// </summary>
        public TRuleMessageActionType ActionType { get; set; }
        /// <summary>
        /// Return the first condition , so the client is able to generate title , when it is empty
        /// </summary>
        public TRuleCondition Condition { get; set; }
        
        public TRuleInfo() { }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleInfo(XmlNode node)
        {
            if (node != null)
            {
                RuleID = Extensions.GetNodeInnerText(node.GetSingleNode("RuleID"));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode("Title"));
                Active = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Active"));
                ActionType = (TRuleMessageActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("ActionType"));

                var condition = node.GetSingleNode("Condition");
                if (condition != null)
                {
                    var className = Extensions.GetNodeInnerText(condition.GetSingleNode("classname"));
                    if (!String.IsNullOrEmpty(className))
                    {
                        var classType = ClassHelper.TRuleConditionClasses()
                                                   .FirstOrDefault(x => x.ClassName.ToLower() == className.ToLower());
                        if (classType != null)
                        {
                            Condition = (TRuleCondition)ClassHelper.GetInstance(classType.AssemblyQualifiedName, new[] { condition });
                        }
                    }
                }
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "RuleID", RuleID);
            XmlHelper.AppendTextElement(element, "Title", Title);
            XmlHelper.AppendTextElement(element, "Active", Active);
            XmlHelper.AppendTextElement(element, "ActionType", ActionType);
            element.AppendChild(Condition.BuildXmlElement(doc, "Condition"));

            return element;
        }
    }
}
