using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Device;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Device
{
    /// <summary>
    /// Get the info list of server, domain or account mobile devices.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetDevicesInfoList">https://www.icewarp.co.uk/api/#GetDevicesInfoList</see></para>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Offset), Offset);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TMobileDevicesInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TMobileDevicesInfoListResponse(httpRequestResult);
        }
    }
}
