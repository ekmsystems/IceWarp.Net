using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that sets message flags.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSetFlagsAction">https://www.icewarp.co.uk/api/#TRuleSetFlagsAction</see></para>
    /// </summary>
    public class TRuleSetFlagsAction : TRuleAction
    {
        public bool Flagged { get; set; }
        public bool Seen { get; set; }
        public bool Junk { get; set; }
        public bool NotJunk { get; set; }
        public bool Label1 { get; set; }
        public bool Label2 { get; set; }
        public bool Label3 { get; set; }
        public bool Label4 { get; set; }
        public bool Label5 { get; set; }
        public bool Label6 { get; set; }

        /// <inheritdoc />
        public TRuleSetFlagsAction()
        {
            Actiontype = TRuleActionType.Flags;
        }

        /// <inheritdoc />
        public TRuleSetFlagsAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Flagged = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Flagged)));
                Seen = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Seen)));
                Junk = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Junk)));
                NotJunk = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => NotJunk)));
                Label1 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label1)));
                Label2 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label2)));
                Label3 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label3)));
                Label4 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label4)));
                Label5 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label5)));
                Label6 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Label6)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Flagged), Flagged);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Seen), Seen);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Junk), Junk);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => NotJunk), NotJunk);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label1), Label1);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label2), Label2);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label3), Label3);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label4), Label4);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label5), Label5);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Label6), Label6);

            return element;
        }
    }
}
