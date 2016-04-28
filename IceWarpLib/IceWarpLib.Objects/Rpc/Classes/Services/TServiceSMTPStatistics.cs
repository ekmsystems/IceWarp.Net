using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Statistic object for SMTP service.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceSMTPStatistics">https://www.icewarp.co.uk/api/#TServiceSMTPStatistics</see></para>
    /// </summary>
    public class TServiceSMTPStatistics : TServiceStatistics
    {
        /// <summary>
        /// Messages received
        /// </summary>
        public long MsgReceived { get; set; }
        /// <summary>
        /// Messages sent
        /// </summary>
        public long MsgSent { get; set; }
        /// <summary>
        /// Failed messages
        /// </summary>
        public long MsgFailed { get; set; }
        /// <summary>
        /// Messages containing virus
        /// </summary>
        public long MsgVirus { get; set; }
        /// <summary>
        /// Messages processed with content filter
        /// </summary>
        public long MsgContentFilter { get; set; }
        /// <summary>
        /// Messages processed with rule
        /// </summary>
        public long MsgRules { get; set; }
        /// <summary>
        /// External filder messages
        /// </summary>
        public long MsgExternal { get; set; }
        /// <summary>
        /// Intrusion prevention messages
        /// </summary>
        public long MsgIntrusionPrevention { get; set; }
        /// <summary>
        /// DNS Messages
        /// </summary>
        public long MsgDNS { get; set; }
        /// <summary>
        /// Quarantine processed messages
        /// </summary>
        public long Quarantine { get; set; }
        /// <summary>
        /// SpamAssasin processed messages
        /// </summary>
        public long SpamAssasin { get; set; }
        /// <summary>
        /// Messages marked as spam
        /// </summary>
        public long SpamMarked { get; set; }
        /// <summary>
        /// AntiSpam Live messages ( bulk )
        /// </summary>
        public long SpamLiveBulk { get; set; }
        /// <summary>
        /// AntiSpam Live messages
        /// </summary>
        public long SpamLive { get; set; }
        /// <summary>
        /// Refused messages
        /// </summary>
        public long Refused { get; set; }
        /// <summary>
        /// Greylisted messages
        /// </summary>
        public long Greylisting { get; set; }

        /// <inheritdoc />
        public TServiceSMTPStatistics()
        {
        }

        /// <inheritdoc />
        public TServiceSMTPStatistics(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                MsgReceived = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgReceived)));
                MsgSent = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgSent)));
                MsgFailed = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgFailed)));
                MsgVirus = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgVirus)));
                MsgContentFilter = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgContentFilter)));
                MsgRules = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgRules)));
                MsgExternal = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgExternal)));
                MsgIntrusionPrevention = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgIntrusionPrevention)));
                MsgDNS = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MsgDNS)));
                Quarantine = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Quarantine)));
                SpamAssasin = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => SpamAssasin)));
                SpamMarked = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => SpamMarked)));
                SpamLiveBulk = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => SpamLiveBulk)));
                SpamLive = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => SpamLive)));
                Refused = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Refused)));
                Greylisting = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Greylisting)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgReceived), MsgReceived);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgSent), MsgSent);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgFailed), MsgFailed);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgVirus), MsgVirus);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgContentFilter), MsgContentFilter);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgRules), MsgRules);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgExternal), MsgExternal);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgIntrusionPrevention), MsgIntrusionPrevention);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MsgDNS), MsgDNS);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Quarantine), Quarantine);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SpamAssasin), SpamAssasin);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SpamMarked), SpamMarked);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SpamLiveBulk), SpamLiveBulk);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => SpamLive), SpamLive);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Refused), Refused);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Greylisting), Greylisting);

            return element;
        }
    }
}
