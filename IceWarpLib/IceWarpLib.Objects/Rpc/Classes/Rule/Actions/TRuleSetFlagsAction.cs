using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Actions
{
    /// <summary>
    /// Action that sets message flags
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <classname>trulesetflagsaction</classname>
    ///         <flagged>boolval</flagged>
    ///         <seen>boolval</seen>
    ///         <junk>boolval</junk>
    ///         <notjunk>boolval</notjunk>
    ///         <label1>boolval</label1>
    ///         <label2>boolval</label2>
    ///         <label3>boolval</label3>
    ///         <label4>boolval</label4>
    ///         <label5>boolval</label5>
    ///         <label6>boolval</label6>
    ///     </custom>
    /// </code>
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

        public TRuleSetFlagsAction() { }
        
        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSetFlagsAction(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Flagged = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Flagged"));
                Seen = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Seen"));
                Junk = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Junk"));
                NotJunk = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("NotJunk"));
                Label1 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label1"));
                Label2 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label2"));
                Label3 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label3"));
                Label4 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label4"));
                Label5 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label5"));
                Label6 = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Label6"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Flagged", Flagged);
            XmlHelper.AppendTextElement(element, "Seen", Seen);
            XmlHelper.AppendTextElement(element, "Junk", Junk);
            XmlHelper.AppendTextElement(element, "NotJunk", NotJunk);
            XmlHelper.AppendTextElement(element, "Label1", Label1);
            XmlHelper.AppendTextElement(element, "Label2", Label2);
            XmlHelper.AppendTextElement(element, "Label3", Label3);
            XmlHelper.AppendTextElement(element, "Label4", Label4);
            XmlHelper.AppendTextElement(element, "Label5", Label5);
            XmlHelper.AppendTextElement(element, "Label6", Label6);

            return element;
        }
    }
}
