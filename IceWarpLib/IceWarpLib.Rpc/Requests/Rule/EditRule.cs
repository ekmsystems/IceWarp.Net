using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Edits RuleSettings of existing rule specified by Id. See <see cref="IceWarpCommand{SuccessResponse}"/> for return type.
    /// </summary>
    public class EditRule : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// The value can be email address(account rules), domain name(domain rules) or empty string (server rules)
        /// </summary>
        public string Who { get; set; }
        /// <summary>
        /// Id of the rule
        /// </summary>
        public int RuleID { get; set; }
        /// <summary>
        /// Detailed settings for current rule. See <see cref="TRuleSettings"/>
        /// </summary>
        public TRuleSettings RuleSettings { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "Who", Who);
            XmlHelper.AppendTextElement(commandParams, "RuleID", RuleID);
            if (RuleSettings != null)
            {
                commandParams.AppendChild(RuleSettings.BuildXmlElement(doc, "RuleSettings"));
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
