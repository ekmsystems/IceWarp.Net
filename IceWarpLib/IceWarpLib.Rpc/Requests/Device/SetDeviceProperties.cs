using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Sets mobile device properties. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
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

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "CommandParams");

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DeviceID), DeviceID);
            if (PropertyValueList != null)
            {
                commandParams.AppendChild(PropertyValueList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyValueList)));
            }

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="SuccessResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
