using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Renames the domain on IceWarp server.
    /// <para><see href="https://www.icewarp.co.uk/api/#RenameDomain">https://www.icewarp.co.uk/api/#RenameDomain</see></para>
    /// </summary>
    public class RenameDomain : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// The name of the domain you want to rename
        /// </summary>
        public string OldName { get; set; }

        /// <summary>
        /// New domain name
        /// </summary>
        public string NewName { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => OldName), OldName);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => NewName), NewName);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
