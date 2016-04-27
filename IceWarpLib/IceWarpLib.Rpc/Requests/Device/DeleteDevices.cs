using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Sets mobile device properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#DeleteDevices">https://www.icewarp.co.uk/api/#DeleteDevices</see></para>
    /// </summary>
    public class DeleteDevices : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        ///  List of DeviceIDs to be deleted
        /// </summary>
        public TPropertyStringList DevicesList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            if (DevicesList != null)
            {
                commandParams.AppendChild(DevicesList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DevicesList)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
