using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpObjects.Rpc.Enums;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Session
{
    /// <summary>
    /// Get the challenge string for RSA authentication type. See <see cref="IceWarpCommand{TAuthChallenge}"/> for return type.
    /// </summary>
    public class GetAuthChallenge : IceWarpCommand<TAuthChallengeResponse>
    {
        /// <summary>
        /// Type of authentication. See <see cref="TAuthType"/> for more information.
        /// </summary>
        public TAuthType AuthType { get { return TAuthType.Rsa; } }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "authtype", ((int)AuthType).ToString());

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TAuthChallengeResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TAuthChallengeResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAuthChallengeResponse(httpRequestResult);
        }
    }
}
