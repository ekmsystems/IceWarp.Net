using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Deletes the list of accounts in specified IceWarp domain. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
    /// </summary>
    public class DeleteAccounts : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }

        /// <summary>
        /// StringList of accounts you want to delete. See <see cref="TPropertyStringList"/> for more information.
        /// </summary>
        public TPropertyStringList AccountList { get; set; }

        /// <summary>
        /// Specifies if all account related data should be deleted or not
        /// </summary>
        public bool LeaveData { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "domainstr", DomainStr);
            commandParams.AppendChild(AccountList.BuildXmlElement(doc, "accountlist"));
            XmlHelper.AppendTextElement(commandParams, "leavedata", LeaveData.ToBitString());

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
