using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes
{
    /// <summary>
    /// Rule condition to match specific words in the message. 
    /// Used in following conditions : From,To,Subject,Date,CC,BCC,ReplyTo,Body,CustomHedaer,AnyHeader,AttachmentName charset,sender,recipient, hostname,senderIP,rDNS,
    /// </summary>
    public class TRuleSomeWordsCondition : TRuleCondition
    {
        /// <summary>
        /// Type of matching function
        /// </summary>
        public TRuleSomeWordsFunctionType MatchFunction { get; set; }
        /// <summary>
        /// Match value
        /// </summary>
        public string MatchValue { get; set; }
        /// <summary>
        /// Case sensitivity
        /// </summary>
        public bool MatchCase { get; set; }
        /// <summary>
        /// Whole words only
        /// </summary>
        public bool MatchWholeWordsOnly { get; set; }
        /// <summary>
        /// Negator
        /// </summary>
        public bool NotMatch { get; set; }
        /// <summary>
        /// Match multiple items type - Only in Content-Filters
        /// </summary>
        public TRuleMultipleItemsMatchType MultipleItemsMatch { get; set; }
        /// <summary>
        /// Parse XML - Only in body matches condition type
        /// </summary>
        public bool ParseXml { get; set; }
        
        public TRuleSomeWordsCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleSomeWordsCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MatchFunction = (TRuleSomeWordsFunctionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("MatchFunction"));
                MatchValue = Extensions.GetNodeInnerText(node.GetSingleNode("MatchValue"));
                MatchCase = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("MatchCase"));
                MatchWholeWordsOnly = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("MatchWholeWordsOnly"));
                NotMatch = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("NotMatch"));
                MultipleItemsMatch = (TRuleMultipleItemsMatchType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("MultipleItemsMatch"));
                ParseXml = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("ParseXml"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "MatchFunction", MatchFunction);
            XmlHelper.AppendTextElement(element, "MatchValue", MatchValue);
            XmlHelper.AppendTextElement(element, "MatchCase", MatchCase);
            XmlHelper.AppendTextElement(element, "MatchWholeWordsOnly", MatchWholeWordsOnly);
            XmlHelper.AppendTextElement(element, "NotMatch", NotMatch);
            XmlHelper.AppendTextElement(element, "MultipleItemsMatch", MultipleItemsMatch);
            XmlHelper.AppendTextElement(element, "ParseXml", ParseXml);

            return element;
        }
    }
}
