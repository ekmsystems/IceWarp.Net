using System;
using System.Linq;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Brief information about some rule in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleInfo">https://www.icewarp.co.uk/api/#TRuleInfo</see></para>
    /// </summary>
    public class TRuleInfo : RpcBaseClass
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

        /// <inheritdoc />
        public TRuleInfo() { }

        /// <inheritdoc />
        public TRuleInfo(XmlNode node)
        {
            if (node != null)
            {
                RuleID = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => RuleID)));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Title)));
                Active = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Active)));
                ActionType = (TRuleMessageActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ActionType)));

                var condition = node.GetSingleNode(ClassHelper.GetMemberName(() => Condition));
                if (condition != null)
                {
                    var className = Extensions.GetNodeInnerText(condition.GetSingleNode(XmlHelper.ClassNameTag));
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

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RuleID), RuleID);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Title), Title);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Active), Active);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ActionType), ActionType);
            element.AppendChild(Condition.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Condition)));

            return element;
        }
    }
}
