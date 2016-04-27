using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Sends the activation key for IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#SendAccountActivationKey">https://www.icewarp.co.uk/api/#SendAccountActivationKey</see></para>
    /// </summary>
    public class SendAccountActivationKey : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Specifies the type of generated key. See <see cref="TActivationKeyType"/> for more information.
        /// </summary>
        public TActivationKeyType KeyType { get; set; }
        /// <summary>
        /// Description of generated key
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Number of allowed activations
        /// </summary>
        public string Count { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => KeyType), KeyType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Description), Description);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
