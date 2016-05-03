using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Domain
{
    /// <summary>
    /// Deletes a domain on IceWarp server.
    /// <para>This method isn't listed on the IceWarp documentation but, it appears to successfully delete domains.</para>
    /// </summary>
    public class DeleteDomain : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Domain to be deleted
        /// </summary>
        public string DomainStr { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            
            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
