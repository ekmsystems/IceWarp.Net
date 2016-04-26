using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Device
{
    /// <summary>
    /// Basic informations about IceWarp mobile device object, is used in mobile device listing
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <deviceid>stringval</deviceid>
    ///         <id>stringval</id>
    ///         <account>stringval</account>
    ///         <name>stringval</name>
    ///         <devicetype>stringval</devicetype>
    ///         <model>stringval</model>
    ///         <os>stringval</os>
    ///         <protocolversion>stringval</protocolversion>
    ///         <registered>stringval</registered>
    ///         <lastsync>stringval</lastsync>
    ///         <remotewipe>enumval</remotewipe>
    ///         <status>enumval</status>
    ///     </custom>
    /// </code>
    public class TMobileDeviceInfo : BaseClass
    {
        /// <summary>
        /// Combined device ID : Base64(AccountID+|+DeviceID)
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// DeviceID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// AccountID
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Device name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Device type
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// Device model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Device OS
        /// </summary>
        public string OS { get; set; }
        /// <summary>
        /// Device protocol version
        /// </summary>
        public string ProtocolVersion { get; set; }
        /// <summary>
        /// Device registration information
        /// </summary>
        public string Registered { get; set; }
        /// <summary>
        /// Date of the last device synchronization
        /// </summary>
        public string LastSync { get; set; }//TODO - check date format
        /// <summary>
        /// Device remote wipe type
        /// </summary>
        public TMobileDeviceRemoteWipe RemoteWipe { get; set; }
        /// <summary>
        /// Device status
        /// </summary>
        public TMobileDeviceStatus Status { get; set; }

        public TMobileDeviceInfo()
        {
        }

        public TMobileDeviceInfo(XmlNode node) : base(node)
        {
            if (node != null)
            {
                DeviceID = Extensions.GetNodeInnerText(node.GetSingleNode("DeviceID"));
                ID = Extensions.GetNodeInnerText(node.GetSingleNode("ID"));
                Account = Extensions.GetNodeInnerText(node.GetSingleNode("Account"));
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
                DeviceType = Extensions.GetNodeInnerText(node.GetSingleNode("DeviceType"));
                Model = Extensions.GetNodeInnerText(node.GetSingleNode("Model"));
                OS = Extensions.GetNodeInnerText(node.GetSingleNode("OS"));
                ProtocolVersion = Extensions.GetNodeInnerText(node.GetSingleNode("ProtocolVersion"));
                Registered = Extensions.GetNodeInnerText(node.GetSingleNode("Registered"));
                LastSync = Extensions.GetNodeInnerText(node.GetSingleNode("LastSync"));
                RemoteWipe = (TMobileDeviceRemoteWipe)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("RemoteWipe"));
                Status = (TMobileDeviceStatus)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Status"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "DeviceID", DeviceID);
            XmlHelper.AppendTextElement(element, "ID", ID);
            XmlHelper.AppendTextElement(element, "Account", Account);
            XmlHelper.AppendTextElement(element, "Name", Name);
            XmlHelper.AppendTextElement(element, "DeviceType", DeviceType);
            XmlHelper.AppendTextElement(element, "Model", Model);
            XmlHelper.AppendTextElement(element, "OS", OS);
            XmlHelper.AppendTextElement(element, "ProtocolVersion", ProtocolVersion);
            XmlHelper.AppendTextElement(element, "Registered", Registered);
            XmlHelper.AppendTextElement(element, "LastSync", LastSync);
            XmlHelper.AppendTextElement(element, "RemoteWipe", RemoteWipe);
            XmlHelper.AppendTextElement(element, "Status", Status);
            return element;
        }
    }
}
