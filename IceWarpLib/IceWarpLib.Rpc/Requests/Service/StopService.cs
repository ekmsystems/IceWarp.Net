using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Service
{
    /// <summary>
    /// Stops the specified IceWarp service.
    /// <para><see href="https://www.icewarp.co.uk/api/#StopService">https://www.icewarp.co.uk/api/#StopService</see></para>
    /// </summary>
    public class StopService : IceWarpCommand<SuccessResponse>
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
