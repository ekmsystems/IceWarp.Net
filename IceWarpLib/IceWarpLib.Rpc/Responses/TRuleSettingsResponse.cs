using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Detailed settings for current rule
    /// </summary>
    /// <code>
    ///     <query>
    ///     <result>
    ///       <conditions>
    ///         <item>
    ///           <classname>truleallcondition</classname>
    ///         </item>
    ///         <item>
    ///           <classname>trulesomewordscondition</classname>
    ///           <matchfunction>enumval</matchfunction>
    ///           <matchvalue>stringval</matchvalue>
    ///           <matchcase>enumval</matchcase>
    ///           <matchwholewordsonly>enumval</matchwholewordsonly>
    ///           <notmatch>enumval</notmatch>
    ///           <multipleitemsmatch>enumval</multipleitemsmatch>
    ///           <parsexml>enumval</parsexml>
    ///         </item>
    ///       </conditions>
    ///       <actions>
    ///         <item>
    ///           <classname>trulepriorityaction</classname>
    ///           <priority>enumval</priority>
    ///         </item>
    ///         <item>
    ///           <classname>trulemovetofolderaction</classname>
    ///           <folder>stringval</folder>
    ///         </item>
    ///       </actions>
    ///       <title>stringval</title>
    ///       <active>enumval</active>
    ///       <ruleid>intval</ruleid>
    ///     </result>
    ///     </query>
    /// </code>
    public class TRuleSettingsResponse : IceWarpResponse
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

        public TRuleSettingsResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
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
    }
}
