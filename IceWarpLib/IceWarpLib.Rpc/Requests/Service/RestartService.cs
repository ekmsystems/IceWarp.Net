using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Service
{
    /// <summary>
    /// Restarts the specified IceWarp service.
    /// <para><see href="https://www.icewarp.co.uk/api/#RestartService">https://www.icewarp.co.uk/api/#RestartService</see></para>
    /// </summary>
    public class RestartService : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Service type specification
        /// </summary>
        public TServiceType Service { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Service), Service);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        /// <returns>See <see cref="SuccessResponse"/></returns>
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
