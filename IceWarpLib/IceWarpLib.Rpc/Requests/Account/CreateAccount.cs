using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Creates an account in the specified IceWarp domain.
    /// <para><see href="https://www.icewarp.co.uk/api/#CreateAccount">https://www.icewarp.co.uk/api/#CreateAccount</see></para>
    /// </summary>
    public class CreateAccount : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Name of IceWarp domain existing on server
        /// </summary>
        public string DomainStr { get; set; }
        /// <summary>
        /// List of account properties with its values you want to set upon creating an account
        /// </summary>
        public TPropertyValueList AccountProperties { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => DomainStr), DomainStr);
            if (AccountProperties != null)
            {
                commandParams.AppendChild(AccountProperties.BuildXmlElement(doc, ClassHelper.GetMemberName(() => AccountProperties)));
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
