using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Generates activation key for IceWarp account
    /// </summary>
    public class GenerateAccountActivationKey : IceWarpCommand<GenerateAccountActivationKeyResponse>
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

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => KeyType), KeyType);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Description), Description);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="GenerateAccountActivationKeyResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override GenerateAccountActivationKeyResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new GenerateAccountActivationKeyResponse(httpRequestResult);
        }
    }
}
