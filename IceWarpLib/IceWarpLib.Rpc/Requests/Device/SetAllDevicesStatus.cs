using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Sets the status of all mobile devices that mathces current Who and Filter.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetAllDevicesStatus">https://www.icewarp.co.uk/api/#SetAllDevicesStatus</see></para>
    /// </summary>
    public class SetAllDevicesStatus : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// The value can be email address(account rules), domain name(domain rules) or empty string (server rules)
        /// </summary>
        public string Who { get; set; }
        /// <summary>
        /// Domain list filter. See <see cref="TMobileDeviceListFilter"/> for more information.
        /// </summary>
        public TMobileDeviceListFilter Filter { get; set; }
        /// <summary>
        /// Type of mobile device remote wipe. See <see cref="TMobileDeviceStatusSet"/>.
        /// </summary>
        public TMobileDeviceStatusSet StatusType { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }
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
