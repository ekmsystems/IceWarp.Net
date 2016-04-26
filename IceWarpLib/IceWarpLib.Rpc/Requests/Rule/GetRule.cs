using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Returns detailed information about rule specified by Who and RuleID
    /// </summary>
    /// <code>
    ///     <iq sid="sidval">
    ///     <query xmlns="admin:iq:rpc">
    ///       <commandname>getrule</commandname>
    ///       <commandparams>
    ///         <who>stringval</who>
    ///         <ruleid>stringval</ruleid>
    ///       </commandparams>
    ///     </query>
    ///     </iq>
    /// </code>
    public class GetRule : IceWarpCommand<TRuleSettingsResponse>
    {
        /// <summary>
        /// The value can be email address(account rules), domain name(domain rules) or empty string (server rules)
        /// </summary>
        public string Who { get; set; }
        /// <summary>
        /// Id of the rule
        /// </summary>
        public int RuleID { get; set; }

        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = XmlHelper.CreateElement(doc, "commandparams");

            XmlHelper.AppendTextElement(commandParams, "Who", Who);
            XmlHelper.AppendTextElement(commandParams, "RuleID", RuleID);

            command.AppendChild(commandParams);
        }

        /// <summary>
        /// Generates the response from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result.</param>
        /// <returns>The response from IceWarp. See <see cref="TRuleSettingsResponse"/> for more information.</returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public override TRuleSettingsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TRuleSettingsResponse(httpRequestResult);
        }
    }
}
