using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Sets the specified mobile device status.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetDeviceStatus">https://www.icewarp.co.uk/api/#SetDeviceStatus</see></para>
    /// </summary>
    public class SetDeviceStatus : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Id of mobile device
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// Type of mobile device remote wipe. See <see cref="TMobileDeviceStatusSet"/>.
        /// </summary>
        public TMobileDeviceStatusSet StatusType { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => StatusType), StatusType);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
