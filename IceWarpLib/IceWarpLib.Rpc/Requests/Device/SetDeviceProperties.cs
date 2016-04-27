using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Sets mobile device properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetDeviceProperties">https://www.icewarp.co.uk/api/#SetDeviceProperties</see></para>
    /// </summary>
    public class SetDeviceProperties : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Id of mobile device
        /// </summary>
        public string DeviceID { get; set; }
        /// <summary>
        ///  List of properties you want to set with its values
        /// </summary>
        public TPropertyValueList PropertyValueList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            if (PropertyValueList != null)
            {
                commandParams.AppendChild(PropertyValueList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyValueList)));
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
