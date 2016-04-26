using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Rule.Conditions
{
    /// <summary>
    /// Local time condition type
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

        public TRuleLocalTimeCondition()
        {
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TRuleLocalTimeCondition(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                Weekdays = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Weekdays"));
                Monday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Monday"));
                Tuesday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Tuesday"));
                Wednesday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Wednesday"));
                Thursday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Thursday"));
                Friday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Friday"));
                Saturday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Saturday"));
                Sunday = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("Sunday"));
                BetweenTimes = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("BetweenTimes"));
                FromTime = Extensions.GetNodeInnerText(node.GetSingleNode("FromTime"));
                ToTime = Extensions.GetNodeInnerText(node.GetSingleNode("ToTime"));
                BetweenDates = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("BetweenDates"));
                FromDate = Extensions.GetNodeInnerText(node.GetSingleNode("FromDate"));
                ToDate = Extensions.GetNodeInnerText(node.GetSingleNode("ToDate"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, "Weekdays", Weekdays);
            XmlHelper.AppendTextElement(element, "Monday", Monday);
            XmlHelper.AppendTextElement(element, "Tuesday", Tuesday);
            XmlHelper.AppendTextElement(element, "Wednesday", Wednesday);
            XmlHelper.AppendTextElement(element, "Thursday", Thursday);
            XmlHelper.AppendTextElement(element, "Friday", Friday);
            XmlHelper.AppendTextElement(element, "Saturday", Saturday);
            XmlHelper.AppendTextElement(element, "Sunday", Sunday);
            XmlHelper.AppendTextElement(element, "BetweenTimes", BetweenTimes);
            XmlHelper.AppendTextElement(element, "FromTime", FromTime);
            XmlHelper.AppendTextElement(element, "ToTime", ToTime);
            XmlHelper.AppendTextElement(element, "BetweenDates", BetweenDates);
            XmlHelper.AppendTextElement(element, "FromDate", FromDate);
            XmlHelper.AppendTextElement(element, "ToDate", ToDate);

            return element;
        }
    }
}
