using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the properties of the existing IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</see></para>
    /// </summary>
    public class GetAccountProperties : IceWarpCommand<TPropertyValueListResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// List of properties you want to get. See <see cref="TAccountPropertyList"/> for more information.
        /// </summary>
        public TAccountPropertyList AccountPropertyList { get; set; }
        /// <summary>
        /// Predefined list of properties
        /// </summary>
        public TAccountPropertySet? AccountPropertySet { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);
            if (AccountPropertyList != null)
            {
                commandParams.AppendChild(AccountPropertyList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => AccountPropertyList)));
            }
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountPropertySet), AccountPropertySet.HasValue ? AccountPropertySet.Value.ToString("d") : TAccountPropertySet.None.ToString("d"));

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TPropertyValueListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyValueListResponse(httpRequestResult);
        }
    }
}
