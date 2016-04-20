using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the list of permissions for specified folder in existing IceWarp account
    /// </summary>
    public class GetAccountAdministrativePermissions : IceWarpCommand<TAdministrativePermissionsResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "accountemail", AccountEmail);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TAdministrativePermissionsResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TAdministrativePermissionsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TAdministrativePermissionsResponse(httpRequestResult);
        }
    }
}
