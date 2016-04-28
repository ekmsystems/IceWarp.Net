using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Statistics object for VOIP service.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceVOIPStatistics">https://www.icewarp.co.uk/api/#TServiceVOIPStatistics</see></para>
    /// </summary>
    public class TServiceVOIPStatistics : TServiceStatistics
    {
        /// <summary>
        /// Packets received
        /// </summary>
        public long PacketsReceived { get; set; }
        /// <summary>
        /// Packets sent
        /// </summary>
        public long PacketsSent { get; set; }
        /// <summary>
        /// RTP packets received
        /// </summary>
        public long RTPPacketsReceived { get; set; }
        /// <summary>
        /// RTP packets sent
        /// </summary>
        public long RTPPacketsSent { get; set; }
        /// <summary>
        /// Calls count
        /// </summary>
        public long CallCount { get; set; }
        /// <summary>
        /// Calls peak
        /// </summary>
        public long CallPeak { get; set; }
        /// <summary>
        /// Calls total
        /// </summary>
        public long CallTotal { get; set; }

        /// <inheritdoc />
        public TServiceVOIPStatistics()
        {
        }

        /// <inheritdoc />
        public TServiceVOIPStatistics(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
                PacketsReceived = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => PacketsReceived)));
                PacketsSent = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => PacketsSent)));
                RTPPacketsReceived = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RTPPacketsReceived)));
                RTPPacketsSent = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RTPPacketsSent)));
                CallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => CallCount)));
                CallPeak = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => CallPeak)));
                CallTotal = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => CallTotal)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PacketsReceived), PacketsReceived);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => PacketsSent), PacketsSent);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RTPPacketsReceived), RTPPacketsReceived);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RTPPacketsSent), RTPPacketsSent);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CallCount), CallCount);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CallPeak), CallPeak);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => CallTotal), CallTotal);

            return element;
        }
    }
}
