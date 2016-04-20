using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    /// <summary>
    /// Gets the list of IMAP and GroupWare folders in specified IceWarp account
    /// </summary>
    public class GetAccountFolderList : IceWarpCommand<TFolderInfoResponse>
    {
        /// <summary>
        /// Name of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// If set to true ,only default folders are returned
        /// </summary>
        public bool OnlyDefault { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "AccountEmail", AccountEmail);
            XmlHelper.AppendTextElement(commandParams, "OnlyDefault", OnlyDefault);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TFolderInfoResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TFolderInfoResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TFolderInfoResponse(httpRequestResult);
        }
    }
}
