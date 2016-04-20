using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    public class DeleteAccountMembers : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// List of members you want to add. See <see cref="TPropertyMembers"/>
        /// </summary>
        public TPropertyMembers Members { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "AccountEmail", AccountEmail);
            commandParams.AppendChild(Members.BuildXmlElement(doc, "Members"));

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
