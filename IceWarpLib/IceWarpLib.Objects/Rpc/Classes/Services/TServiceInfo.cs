using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Brief information about IceWarp service.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceInfo">https://www.icewarp.co.uk/api/#TServiceInfo</see></para>
    /// </summary>
    public class TServiceInfo : RpcBaseClass
    {
        /// <summary>
        /// Service type
        /// </summary>
        public TServiceType ServiceType { get; set; }
        /// <summary>
        /// Running time
        /// </summary>
        public long Uptime { get; set; }
        /// <summary>
        /// Connection count
        /// </summary>
        public int Connections { get; set; }
        /// <summary>
        /// Max Connections count
        /// </summary>
        public int MaxConnections { get; set; }
        /// <summary>
        /// Data ( memory )
        /// </summary>
        public long Data { get; set; }
        /// <summary>
        /// Specifies if the service is running or not
        /// </summary>
        public bool IsRunning { get; set; }

        /// <inheritdoc />
        public TServiceInfo()
        {
        }

        /// <inheritdoc />
        public TServiceInfo(XmlNode node)
        {
            if (node != null)
            {
                ServiceType = (TServiceType)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => ServiceType)));
                Uptime = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Uptime)));
                Connections = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Connections)));
                MaxConnections = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => MaxConnections)));
                Data = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Data)));
                IsRunning = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => IsRunning)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ServiceType), ServiceType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Uptime), Uptime);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Connections), Connections);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => MaxConnections), MaxConnections);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Data), Data);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => IsRunning), IsRunning);
            return element;
        }
    }
}
