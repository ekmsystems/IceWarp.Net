using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Abstract class for service statistics.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceStatistics">https://www.icewarp.co.uk/api/#TServiceStatistics</see></para>
    /// <para/>Descendants:
    /// <para/><see cref="TServiceBasicStatistics"/>
    /// <para/><see cref="TServiceVOIPStatistics"/>
    /// <para/><see cref="TServiceSMTPStatistics"/>
    /// </summary>
    public abstract class TServiceStatistics : RpcBaseClass
    {
        /// <summary>
        /// Running time
        /// </summary>
        public long Uptime { get; set; }
        /// <summary>
        /// Total connections
        /// </summary>
        public long ConnTotal { get; set; }
        /// <summary>
        /// Server connections
        /// </summary>
        public long ServerConn { get; set; }
        /// <summary>
        /// Server connections peak
        /// </summary>
        public long ServerConnPeak { get; set; }
        /// <summary>
        /// Server data total
        /// </summary>
        public long ServerDataTotal { get; set; }
        /// <summary>
        /// Server data in
        /// </summary>
        public long ServerDataIn { get; set; }
        /// <summary>
        /// Server data out
        /// </summary>
        public long ServerDataOut { get; set; }
        /// <summary>
        /// Client connections
        /// </summary>
        public long ClientConn { get; set; }
        /// <summary>
        /// Client connections peak
        /// </summary>
        public long ClientConnPeak { get; set; }
        /// <summary>
        /// Client data total
        /// </summary>
        public long ClientDataTotal { get; set; }
        /// <summary>
        /// Client data in
        /// </summary>
        public long ClientDataIn { get; set; }
        /// <summary>
        /// Client data out
        /// </summary>
        public long ClientDataOut { get; set; }
        /// <summary>
        /// Memory size
        /// </summary>
        public long MemorySize { get; set; }
        /// <summary>
        /// Memory peak
        /// </summary>
        public long MemoryPeak { get; set; }

        /// <summary>
        /// Populates fields from an XML node.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/></param>
        protected void ProcessNode(XmlNode node)
        {
            Uptime = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Uptime)));
            ConnTotal = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ConnTotal)));
            ServerConn = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServerConn)));
            ServerConnPeak = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServerConnPeak)));
            ServerDataTotal = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServerDataTotal)));
            ServerDataIn = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServerDataIn)));
            ServerDataOut = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServerDataOut)));
            ClientConn = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ClientConn)));
            ClientConnPeak = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ClientConnPeak)));
            ClientDataTotal = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ClientDataTotal)));
            ClientDataIn = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ClientDataIn)));
            ClientDataOut = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ClientDataOut)));
            MemorySize = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MemorySize)));
            MemoryPeak = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MemoryPeak)));
        }
        /// <summary>
        /// Appends base fields to an XML element.
        /// </summary>
        /// <param name="element">The XML element. See <see cref="XmlElement"/></param>
        protected void AppendBaseElements(XmlElement element)
        {
            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Uptime), Uptime);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ConnTotal), ConnTotal);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServerConn), ServerConn);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServerConnPeak), ServerConnPeak);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServerDataTotal), ServerDataTotal);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServerDataIn), ServerDataIn);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServerDataOut), ServerDataOut);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ClientConn), ClientConn);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ClientConnPeak), ClientConnPeak);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ClientDataTotal), ClientDataTotal);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ClientDataIn), ClientDataIn);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ClientDataOut), ClientDataOut);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MemorySize), MemorySize);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MemoryPeak), MemoryPeak);
        }
    }
}
