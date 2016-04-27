using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes the members from the specified IceWarp account. Available for groups and mailing lists
    /// <para><see href="https://www.icewarp.co.uk/api/#DeleteAccountMembers">https://www.icewarp.co.uk/api/#DeleteAccountMembers</see></para>
    /// </summary>
    public class DeleteAccountMembers : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server.
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// List of members you want to add. See <see cref="TPropertyMembers"/>
        /// </summary>
        public TPropertyMembers Members { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            commandParams.AppendChild(Members.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Members)));

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
