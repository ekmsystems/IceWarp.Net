using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Get the info list of server, domain or account mobile devices. See <see cref="IceWarpCommand{TMobileDevicesInfoListResponse}"/> for return type.
    /// </summary>
    public class GetDevicesInfoList : IceWarpCommand<TMobileDevicesInfoListResponse>
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
        /// Specifies offset start of returned items.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Specifies count of returned items.
        /// </summary>
        public int Count { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "Who", Who);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, "filter"));
            }
            XmlHelper.AppendTextElement(commandParams, "Offset", Offset);
            XmlHelper.AppendTextElement(commandParams, "Count", Count);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TMobileDevicesInfoListResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TMobileDevicesInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TMobileDevicesInfoListResponse(httpRequestResult);
        }
    }
}
