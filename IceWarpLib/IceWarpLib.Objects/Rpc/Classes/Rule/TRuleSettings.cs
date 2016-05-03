using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Represents the settings of the rule.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSettings">https://www.icewarp.co.uk/api/#TRuleSettings</see></para>
    /// </summary>
    public class TRuleSettings : RpcBaseClass
    {
        /// <summary>
        /// List of conditions
        /// </summary>
        public TRuleConditions Conditions { get; set; }
        /// <summary>
        /// List of actions
        /// </summary>
        public TRuleActions Actions { get; set; }
        /// <summary>
        /// Rule title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Active state of the rule
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Rule ID
        /// </summary>
        public int RuleID { get; set; }

        /// <inheritdoc />
        public TRuleSettings()
        {
            Conditions = new TRuleConditions();
            Actions = new TRuleActions();
        }

        /// <inheritdoc />
        public TRuleSettings(XmlNode node) : base(node)
        {
            if (node != null)
            {
                Conditions = new TRuleConditions(node.GetSingleNode(ClassHelper.GetMemberName(() => Conditions)));
                Actions = new TRuleActions(node.GetSingleNode(ClassHelper.GetMemberName(() => Actions)));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Title)));
                Active = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Active)));
                RuleID = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RuleID)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(Conditions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Conditions)));
            element.AppendChild(Actions.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Actions)));
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Title), Title);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Active), Active);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RuleID), RuleID);

            return element;
        }
    }
}
