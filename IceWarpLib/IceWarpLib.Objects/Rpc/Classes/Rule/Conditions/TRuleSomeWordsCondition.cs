using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Rule condition to match specific words in the message. 
    /// <para/>Used in following conditions : From,To,Subject,Date,CC,BCC,ReplyTo,Body,CustomHedaer,AnyHeader,AttachmentName charset,sender,recipient, hostname,senderIP,DNS,.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleSomeWordsCondition">https://www.icewarp.co.uk/api/#TRuleSomeWordsCondition</see></para>
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

        /// <inheritdoc />
        public TRuleSomeWordsCondition()
        {
            
        }

        /// <inheritdoc />
        public TRuleSomeWordsCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MatchFunction = (TRuleSomeWordsFunctionType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MatchFunction)));
                MatchValue = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => MatchValue)));
                MatchCase = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => MatchCase)));
                MatchWholeWordsOnly = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => MatchWholeWordsOnly)));
                NotMatch = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => NotMatch)));
                MultipleItemsMatch = (TRuleMultipleItemsMatchType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MultipleItemsMatch)));
                ParseXml = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => ParseXml)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MatchFunction), MatchFunction);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MatchValue), MatchValue);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MatchCase), MatchCase);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MatchWholeWordsOnly), MatchWholeWordsOnly);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => NotMatch), NotMatch);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MultipleItemsMatch), MultipleItemsMatch);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ParseXml), ParseXml);

            return element;
        }
    }
}
