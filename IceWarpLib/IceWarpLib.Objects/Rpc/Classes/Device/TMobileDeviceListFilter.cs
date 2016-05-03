using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Device
{
    /// <summary>
    /// Used to filter the list of mobile devices in IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#TMobileDeviceListFilter">https://www.icewarp.co.uk/api/#TMobileDeviceListFilter</see></para>
    /// </summary>
    public class TMobileDeviceListFilter : RpcBaseClass
    {
        /// <summary>
        /// Used against mobile device name
        /// </summary>
        public string NameMask { get; set; }
        /// <summary>
        /// Used against mobile device status
        /// </summary>
        public TMobileDeviceStatus Status { get; set; }
        /// <summary>
        /// Synced during last N days
        /// </summary>
        public int? LastSync { get; set; }

        /// <inheritdoc />
        public TMobileDeviceListFilter()
        {
        }

        /// <inheritdoc />
        public TMobileDeviceListFilter(XmlNode node) : base(node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => NameMask)));
                Status = (TMobileDeviceStatus)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Status)));
                LastSync = Extensions.GetNodeInnerTextAsNullableInt(node.GetSingleNode(ClassHelper.GetMemberName(() => LastSync)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => NameMask), NameMask);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Status), Status);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => LastSync), LastSync);
            return element;
        }
    }
}
