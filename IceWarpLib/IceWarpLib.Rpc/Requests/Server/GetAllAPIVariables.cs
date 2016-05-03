using System.Xml;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Server
{
    /// <summary>
    /// Gets the list of all api variables and its comments
    /// </summary>
    public class GetAllAPIVariables : IceWarpCommand<TPropertyTranslateListResponse>
    {
        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(GetCommandParamsElement(doc));
        }

        /// <inheritdoc />
        public override TPropertyTranslateListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyTranslateListResponse(httpRequestResult);
        }
    }
}
