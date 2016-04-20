using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    /// <summary>
    /// Generates a password for an IceWarp account according to current Password policy
    /// </summary>
    public class GenerateAccountPassword : IceWarpCommand<GeneratedPasswordResponse>
    {
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(XmlHelper.CreateElement(doc, "commandparams"));
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="GeneratedPasswordResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override GeneratedPasswordResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new GeneratedPasswordResponse(httpRequestResult);
        }
    }
}
