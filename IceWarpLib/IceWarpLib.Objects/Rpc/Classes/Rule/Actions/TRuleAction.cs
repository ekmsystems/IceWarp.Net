using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Abstract class that represents action defined in rule.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleAction">https://www.icewarp.co.uk/api/#TRuleAction</see></para>
    /// <para/>Descendants:
    /// <para/><see cref="TRuleSendMessageAction"/>
    /// <para/><see cref="TRuleForwardToEmailAction"/>
    /// <para/><see cref="TRuleMoveToFolderAction"/>
    /// <para/><see cref="TRuleCopyToFolderAction"/>
    /// <para/><see cref="TRuleEncryptAction"/>
    /// <para/><see cref="TRulePriorityAction"/>
    /// <para/><see cref="TRuleSetFlagsAction"/>
    /// <para/><see cref="TRuleEditHeaderAction"/>
    /// <para/><see cref="TRuleMessageActionAction"/>
    /// <para/><see cref="TRuleStopAction"/>
    /// </summary>
    public abstract class TRuleAction : RpcBaseClass
    {
        /// <summary>
        /// Type of the action
        /// </summary>
        public TRuleActionType Actiontype { get; set; }

        /// <inheritdoc />
        protected void ProcessNode(XmlNode node)
        {
            Actiontype = (TRuleActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Actiontype)));
        }

        /// <inheritdoc />
        protected void AppendBaseElements(XmlElement element)
        {
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Actiontype), Actiontype);
        }
    }
}
