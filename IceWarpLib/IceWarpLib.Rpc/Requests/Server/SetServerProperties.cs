using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Requests.Server
{
    /// <summary>
    /// Sets the values of server properties.
    /// <para><see href="https://www.icewarp.co.uk/api/#SetServerProperties">https://www.icewarp.co.uk/api/#SetServerProperties</see></para>
    /// </summary>
    public class SetServerProperties : IceWarpCommand<SuccessResponse>
    {
        /// <summary>
        /// Specifies the list of variables you want to set with its values
        /// </summary>
        public TPropertyValueList PropertyValueList { get; set; }

        /// <inheritdoc />
        protected override void BuildCommandParams(XmlDocument doc, XmlElement command)
        {
            var commandParams = GetCommandParamsElement(doc);

            if (PropertyValueList != null)
            {
                commandParams.AppendChild(PropertyValueList.BuildXmlElement(doc, ClassHelper.GetMemberName(() => PropertyValueList)));
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
