using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Rule
{
    /// <summary>
    /// Move specified Rule up or down.
    /// <para><see href="https://www.icewarp.co.uk/api/#MoveRule">https://www.icewarp.co.uk/api/#MoveRule</see></para>
    /// </summary>
    public class MoveRule : IceWarpCommand<SuccessResponse>
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
        /// Specifies whether to move rule up or down. <see cref="TRuleMoveType"/>
        /// </summary>
        public TRuleMoveType MoveType { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Who), Who);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => RuleID), RuleID);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => MoveType), MoveType);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override SuccessResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new SuccessResponse(httpRequestResult);
        }
    }
}
