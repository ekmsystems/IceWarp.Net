using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Exceptions;
using IceWarpRpc.Responses;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Requests.Account
{
    /// <summary>
    /// Adds the members to the specified IceWarp account. Members are specified by IceWarp domain name and current account filter. Available for groups and mailing lists
    /// </summary>
    public class AddAllAccountMembers : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// Account list filter
        /// </summary>
        public TAccountListFilter Filter { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "AccountEmail", AccountEmail);
            XmlHelper.AppendTextElement(commandParams, "DomainStr", DomainStr);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, "Filter"));
            }

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
