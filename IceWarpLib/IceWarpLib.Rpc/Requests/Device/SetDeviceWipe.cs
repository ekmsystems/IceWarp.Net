using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Marks selected mobile device for remote wipe.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetDeviceWipe">https://www.icewarp.co.uk/api/#SetDeviceWipe</see></para>
    /// </summary>
    public class SetDeviceWipe : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Id of mobile device
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// Type of mobile device remote wipe. See <see cref="TMobileDeviceRemoteWipeSet"/>.
        /// </summary>
        public TMobileDeviceRemoteWipeSet WipeType { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => WipeType), WipeType);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
