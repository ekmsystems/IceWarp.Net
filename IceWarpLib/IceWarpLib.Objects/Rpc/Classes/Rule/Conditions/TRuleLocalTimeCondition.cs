using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Local time condition type.
    /// <para><see href="https://www.icewarp.co.uk/api/#TRuleLocalTimeCondition">https://www.icewarp.co.uk/api/#TRuleLocalTimeCondition</see></para>
    /// </summary>
    public class TRuleLocalTimeCondition : TRuleCondition
    {
        /// <summary>
        /// Match days in the week
        /// </summary>
        public bool Weekdays { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        /// <summary>
        /// Match only if between times
        /// </summary>
        public bool BetweenTimes { get; set; }
        /// <summary>
        /// From time
        /// </summary>
        public string FromTime { get; set; }
        /// <summary>
        /// To time
        /// </summary>
        public string ToTime { get; set; }
        /// <summary>
        /// Match only if between dates
        /// </summary>
        public bool BetweenDates { get; set; }
        /// <summary>
        /// From date
        /// </summary>
        public string FromDate { get; set; }
        /// <summary>
        /// To date
        /// </summary>
        public string ToDate { get; set; }

        /// <inheritdoc />
        public TRuleLocalTimeCondition()
        {
            ConditionType = TRuleConditionType.Time;
        }

        /// <inheritdoc />
        public TRuleLocalTimeCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Weekdays = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Weekdays)));
                Monday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Monday)));
                Tuesday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Tuesday)));
                Wednesday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Wednesday)));
                Thursday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Thursday)));
                Friday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Friday)));
                Saturday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Saturday)));
                Sunday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Sunday)));
                BetweenTimes = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => BetweenTimes)));
                FromTime = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FromTime)));
                ToTime = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ToTime)));
                BetweenDates = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => BetweenDates)));
                FromDate = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FromDate)));
                ToDate = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ToDate)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Weekdays), Weekdays);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Monday), Monday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Tuesday), Tuesday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Wednesday), Wednesday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Thursday), Thursday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Friday), Friday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Saturday), Saturday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Sunday), Sunday);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BetweenTimes), BetweenTimes);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FromTime), FromTime);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ToTime), ToTime);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => BetweenDates), BetweenDates);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FromDate), FromDate);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ToDate), ToDate);

            return element;
        }
    }
}
