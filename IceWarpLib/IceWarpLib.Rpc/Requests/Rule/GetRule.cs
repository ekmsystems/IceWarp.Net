using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Returns detailed information about rule specified by Who and RuleID.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetRule">https://www.icewarp.co.uk/api/#GetRule</see></para>
    /// </summary>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => RuleID), RuleID);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TRuleSettingsResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TRuleSettingsResponse(httpRequestResult);
        }
    }
}
