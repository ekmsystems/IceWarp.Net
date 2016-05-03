using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Server;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Server
{
    /// <summary>
    /// Gets the properties of the existing IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</see></para>
    /// </summary>
    public class GetServerProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// Specifies the list of variables you want to get
        /// </summary>
        public TServerPropertyList ServerPropertyList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            if (ServerPropertyList != null)
            {
                commandParams.AppendChild(ServerPropertyList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => ServerPropertyList)));
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
