using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that moves the message into specified folder.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleMoveToFolderAction">https://www.icewarp.co.uk/api/#TRuleMoveToFolderAction</see></para>
    /// </summary>
    public class TRuleMoveToFolderAction : TRuleAction
    {
        /// <summary>
        /// Target folder
        /// </summary>
        public string Folder { get; set; }

        /// <inheritdoc />
        public TRuleMoveToFolderAction()
        {
            Actiontype = TRuleActionType.MoveFolder;
        }

        /// <inheritdoc />
        public TRuleMoveToFolderAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Folder = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Folder)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Folder), Folder);

            return element;
        }
    }
}
