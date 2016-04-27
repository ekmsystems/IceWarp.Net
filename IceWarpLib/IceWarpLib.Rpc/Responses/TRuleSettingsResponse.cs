using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Detailed settings for current rule.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSettings ">https://www.icewarp.co.uk/api/#TRuleSettings </see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetRule">https://www.icewarp.co.uk/api/#GetRule</seealso></para>
    /// </summary>
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

        /// <inheritdoc />
        public TRuleSettingsResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
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
    }
}
