using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule
{
    /// <summary>
    /// Abstract class that represents action defined in rule
    /// Descendants:
    /// <see cref="TRuleSendMessageAction"/>
    /// <see cref="TRuleForwardToEmailAction"/>
    /// <see cref="TRuleMoveToFolderAction"/>
    /// <see cref="TRuleCopyToFolderAction"/>
    /// <see cref="TRuleEncryptAction"/>
    /// <see cref="TRulePriorityAction"/>
    /// <see cref="TRuleSetFlagsAction"/>
    /// <see cref="TRuleEditHeaderAction"/>
    /// <see cref="TRuleMessageActionAction"/>
    /// <see cref="TRuleStopAction"/>
    /// </summary>
    public abstract class TRuleAction : BaseClass
    {
        public TRuleActionType Actiontype { get; set; }

        protected void ProcessNode(XmlNode node)
        {
            Actiontype = (TRuleActionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Actiontype"));
        }

        protected void AppendBaseElements(XmlElement element)
        {
            XmlHelper.AppendTextElement(element, "ClassName", ClassName);
            XmlHelper.AppendTextElement(element, "Actiontype", Actiontype);
        }
    }
}
