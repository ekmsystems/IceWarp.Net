using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that stops processing more rules in the list.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleStopAction">https://www.icewarp.co.uk/api/#TRuleStopAction</see></para>
    /// </summary>
    public class TRuleStopAction : TRuleAction
    {
        /// <inheritdoc />
        public TRuleStopAction()
        {
            Actiontype = TRuleActionType.Stop;
        }

        /// <inheritdoc />
        public TRuleStopAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);

            return element;
        }
    }
}
