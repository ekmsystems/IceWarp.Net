using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes all accounts that matches current filter in specified IceWarp domain. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
    /// </summary>
    public class DeleteAllAccounts : IceWarpCommand<SuccessResponse>
    {
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

            XmlHelper.AppendTextElement(commandParams, "domainstr", DomainStr);
            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, "filter"));
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
