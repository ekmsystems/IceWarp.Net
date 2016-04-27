using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes all members from the IceWarp account. Available for groups and mailing lists
    /// <para><see href="https://www.icewarp.co.uk/api/#DeleteAllAccountMembers">https://www.icewarp.co.uk/api/#DeleteAllAccountMembers</see></para>
    /// </summary>
    public class DeleteAllAccountMembers : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server.
        /// </summary>
        public string AccountEmail { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
