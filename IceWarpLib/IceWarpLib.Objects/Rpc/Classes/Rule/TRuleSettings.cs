using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Represents the settings of the rule
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <conditions>
    ///           <item>
    ///             <classname>truleisspamcondition</classname>
    ///           </item>
    ///           <item>
    ///             <classname>trulespamscorecondition</classname>
    ///             <comparetype>enumval</comparetype>
    ///             <spamscore>stringval</spamscore>
    ///           </item>
    ///         </conditions>
    ///         <actions>
    ///           <item>
    ///             <classname>trulemovetofolderaction</classname>
    ///             <folder>stringval</folder>
    ///           </item>
    ///           <item>
    ///             <classname>trulestopaction</classname>
    ///           </item>
    ///         </actions>
    ///         <title>stringval</title>
    ///         <active>enumval</active>
    ///         <ruleid>intval</ruleid>
    ///     </custom>
    /// </code>
    public class TRuleSettings : BaseClass
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

        public TRuleSettings()
        {
            Conditions = new TRuleConditions();
            Actions = new TRuleActions();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSettings(XmlNode node) : base(node)
        {
            if (node != null)
            {
                Conditions = new TRuleConditions(node.GetSingleNode("Conditions"));
                Actions = new TRuleActions(node.GetSingleNode("Actions"));
                Title = Extensions.GetNodeInnerText(node.GetSingleNode("Title"));
                Active = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Active"));
                RuleID = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RuleID"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            element.AppendChild(Conditions.BuildXmlElement(doc, "Conditions"));
            element.AppendChild(Actions.BuildXmlElement(doc, "Actions"));
            XmlHelper.AppendTextElement(element, "Title", Title);
            XmlHelper.AppendTextElement(element, "Active", Active);
            XmlHelper.AppendTextElement(element, "RuleID", RuleID);

            return element;
        }
    }
}
