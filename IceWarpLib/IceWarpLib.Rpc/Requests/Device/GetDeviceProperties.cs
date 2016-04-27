using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Gets mobile device properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetDeviceProperties">https://www.icewarp.co.uk/api/#GetDeviceProperties</see></para>
    /// </summary>
    public class GetDeviceProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// Id of mobile device
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        /// List of properties you want to retrieve
        /// </summary>
        public TDevicePropertyList DevicePropertyList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            if (DevicePropertyList != null)
            {
                commandParams.AppendChild(DevicePropertyList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => DevicePropertyList)));
            }
            
            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TPropertyValueListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyValueListResponse(httpRequestResult);
        }
    }
}
