using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Session
{
    /// <summary>
    /// Logs the user out and destroy his session. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
    /// </summary>
    public class Logout : IceWarpCommand<SuccessResponse>
    {
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            command.AppendChild(XmlHelper.CreateElement(doc, "commandparams"));
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
