using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Edits RuleSettings of existing rule specified by Id.
    /// <para><see href="https://www.icewarp.co.uk/api/#EditRule">https://www.icewarp.co.uk/api/#EditRule</see></para>
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

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => RuleID), RuleID);
            if (RuleSettings != null)
            {
                commandParams.AppendChild(RuleSettings.BuildXmlElement(doc, ClassHelper.GetMemberName(() => RuleSettings)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
