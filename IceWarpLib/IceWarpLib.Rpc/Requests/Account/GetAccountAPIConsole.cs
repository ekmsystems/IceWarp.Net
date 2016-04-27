using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Account
{
    /// <summary>
    /// Gets the list of account api variables, its values, data types and rights, its values, data types and rights.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetAccountAPIConsole">https://www.icewarp.co.uk/api/#GetAccountAPIConsole</see></para>
    /// </summary>
    public class GetAccountAPIConsole : IceWarpCommand<TPropertyInfoListResponse>
    {
        /// <summary>
        /// Email address of IceWarp account existing on server
        /// </summary>
        public string AccountEmail { get; set; }
        /// <summary>
        /// Filter for account api variables. See <see cref="TPropertyListFilter"/> for more information.
        /// </summary>
        public TPropertyListFilter Filter { get; set; }
        /// <summary>
        /// Specifies offset start of returned items.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Specifies count of returned items.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Specifies whether return comments or not
        /// </summary>
        public bool Comments { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => AccountEmail), AccountEmail);

            if (Filter != null)
            {
                commandParams.AppendChild(Filter.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Filter)));
            }

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Offset), Offset);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Count), Count);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Comments), Comments);

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TPropertyInfoListResponse FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TPropertyInfoListResponse(httpRequestResult);
        }
    }
}
