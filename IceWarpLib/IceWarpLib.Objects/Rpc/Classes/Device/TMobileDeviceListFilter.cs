using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Device
{
    /// <summary>
    /// Used to filter the list of mobile devices in IceWarp server
    /// </summary>
    /// <code>
    ///     <custom>
    ///         <namemask>stringval</namemask>
    ///         <status>enumval</status>
    ///         <lastsync>intval</lastsync>
    ///     </custom>
    /// </code>
    public class TMobileDeviceListFilter : BaseClass
    {
        /// <summary>
        /// Used agains mobile device name
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

        public TMobileDeviceListFilter()
        {
        }

        public TMobileDeviceListFilter(XmlNode node) : base(node)
        {
            if (node != null)
            {
                NameMask = Extensions.GetNodeInnerText(node.GetSingleNode("NameMask"));
                Status = (TMobileDeviceStatus)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Status"));
                LastSync = Extensions.GetNodeInnerTextAsNullableInt(node.GetSingleNode("LastSync"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, "NameMask", NameMask);
            XmlHelper.AppendTextElement(element, "Status", Status);
            XmlHelper.AppendTextElement(element, "LastSync", LastSync);
            return element;
        }
    }
}
