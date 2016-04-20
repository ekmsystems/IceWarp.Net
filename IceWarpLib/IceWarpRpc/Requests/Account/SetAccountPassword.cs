using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpObjects.Rpc.Enums;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    /// <summary>
    /// Changes the password of existing IceWarp account
    /// </summary>
    public class SetAccountPassword : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Type of authentication. See <see cref="TAuthType"/> for more information.
        /// </summary>
        public TAuthType AuthType { get; set; }
        /// <summary>
        /// Account plain text password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// RSA encrypted password
        /// </summary>
        public string Digest { get; set; }
        /// <summary>
        /// If set, the process ignores the current password policy
        /// </summary>
        public bool IgnorePolicy { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "AccountEmail", AccountEmail);
            XmlHelper.AppendTextElement(commandParams, "AuthType", AuthType);
            XmlHelper.AppendTextElement(commandParams, "Password", Password);
            XmlHelper.AppendTextElement(commandParams, "Digest", Digest);
            XmlHelper.AppendTextElement(commandParams, "IgnorePolicy", IgnorePolicy);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="SuccessResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
