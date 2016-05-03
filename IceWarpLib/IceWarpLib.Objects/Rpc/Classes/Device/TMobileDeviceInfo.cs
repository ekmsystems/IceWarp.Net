using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Device
{
    /// <summary>
    /// Basic informations about IceWarp mobile device object, is used in mobile device listing.
    /// <para><see href="https://www.icewarp.co.uk/api/#TMobileDeviceInfo">https://www.icewarp.co.uk/api/#TMobileDeviceInfo</see></para>
    /// </summary>
    public class TMobileDeviceInfo : RpcBaseClass
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

        /// <inheritdoc />
        public TMobileDeviceInfo()
        {
        }

        /// <inheritdoc />
        public TMobileDeviceInfo(XmlNode node) : base(node)
        {
            if (node != null)
            {
                DeviceID = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DeviceID)));
                ID = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ID)));
                Account = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Account)));
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                DeviceType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DeviceType)));
                Model = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Model)));
                OS = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => OS)));
                ProtocolVersion = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ProtocolVersion)));
                Registered = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Registered)));
                LastSync = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => LastSync)));
                RemoteWipe = (TMobileDeviceRemoteWipe)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => RemoteWipe)));
                Status = (TMobileDeviceStatus)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Status)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ID), ID);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Account), Account);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DeviceType), DeviceType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Model), Model);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => OS), OS);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ProtocolVersion), ProtocolVersion);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Registered), Registered);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LastSync), LastSync);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => RemoteWipe), RemoteWipe);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Status), Status);
            return element;
        }
    }
}
