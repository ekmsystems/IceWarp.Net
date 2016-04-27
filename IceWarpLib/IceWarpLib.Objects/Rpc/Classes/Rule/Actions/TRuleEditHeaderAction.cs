using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that copies the message into specified folder.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleEditHeaderAction">https://www.icewarp.co.uk/api/#TRuleEditHeaderAction</see></para>
    /// </summary>
    public class TRuleEditHeaderAction : TRuleAction
    {
        /// <summary>
        /// Target folder
        /// </summary>
        public TRuleEditHeaderList Headers { get; set; }

        /// <inheritdoc />
        public TRuleEditHeaderAction()
        {
            Actiontype = TRuleActionType.Header;
        }

        /// <inheritdoc />
        public TRuleEditHeaderAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Headers = new TRuleEditHeaderList(node.GetSingleNode(ClassHelper.GetMemberName(() => Headers)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            element.AppendChild(Headers.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Headers)));

            return element;
        }
    }
}
