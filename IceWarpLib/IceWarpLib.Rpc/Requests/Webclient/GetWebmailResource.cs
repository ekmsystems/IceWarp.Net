using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Webclient
{
    /// <summary>
    /// Gets webclient setting properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetWebmailResource">https://www.icewarp.co.uk/api/#GetWebmailResource</see></para>
    /// </summary>
    public class GetWebmailResource : IceWarpCommand<TWebmailSettingsResource>
    {
        /// <summary>
        /// Webclient resource name
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// Level
        /// </summary>
        public TWebmailSettingLevel Level { get; set; }
        /// <summary>
        /// Depends on Level : 0 - empty, 1 - Domain name, 2 - Account email address
        /// </summary>
        public string Selector { get; set; }
        /// <summary>
        /// Optional filter on which variable names you want to get from selected resource name
        /// </summary>
        public TPropertyStringList Items { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Resource), Resource);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Level), Level);
            XmlHelper.AppendTextElement(commandParams, ClassHelper.GetMemberName(() => Selector), Level == TWebmailSettingLevel.Server ? "" : Selector);
            if (Items != null)
            {
                commandParams.AppendChild(Items.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Items)));
            }

            command.AppendChild(commandParams);
        }

        /// <inheritdoc />
        public override TWebmailSettingsResource FromHttpRequestResult(HttpRequestResult httpRequestResult)
        {
            return new TWebmailSettingsResource(httpRequestResult);
        }
    }
}
