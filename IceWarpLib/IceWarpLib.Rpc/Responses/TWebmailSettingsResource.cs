using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Webclient;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents the resource in webclient settings.
    /// <para><see href="https://www.icewarp.co.uk/api/#TWebmailSettingsResource">https://www.icewarp.co.uk/api/#TWebmailSettingsResource</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetWebmailResource">https://www.icewarp.co.uk/api/#GetWebmailResource</seealso></para>
    /// </summary>
    public class TWebmailSettingsResource : IceWarpResponse
    {
        /// <summary>
        /// List of items in the resource
        /// </summary>
        public TWebmailSettingItemList List { get; set; }
        /// <summary>
        /// Resource name
        /// </summary>
        public string Name { get; set; }

        /// <inheritdoc />
        public TWebmailSettingsResource(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                List = new TWebmailSettingItemList(node.GetSingleNode(ClassHelper.GetMemberName(() => List)));
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
            }
        }
    }
}
