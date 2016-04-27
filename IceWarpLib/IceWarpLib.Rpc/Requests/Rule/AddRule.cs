using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Rule;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Creates new rule from RuleSettings.
    /// <para><see href="https://www.icewarp.co.uk/api/#AddRule">https://www.icewarp.co.uk/api/#AddRule</see></para>
    /// </summary>
    public class AddRule : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// The value can be email address(account rules), domain name(domain rules) or empty string (server rules)
        /// </summary>
        public string Who { get; set; }
        /// <summary>
        /// Detailed settings for current rule. See <see cref="TRuleSettings"/>
        /// </summary>
        public TRuleSettings RuleSettings { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
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
