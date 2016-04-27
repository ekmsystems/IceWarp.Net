using System;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc
{
    /// <summary>
    /// Abstract base class for an API command.
    /// </summary>
    /// <typeparam name="T">API method return type See <see cref="IceWarpResponse"/> for more information.</typeparam>
    public abstract class IceWarpCommand<T> where T : IceWarpResponse
    {
        /// <summary>
        /// The API sid (session id).
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Appends the command params XML element to the XML document.
        /// </summary>
        /// <param name="doc">The XML document See <see cref="XmlDocument"/> for more information.</param>
        /// <param name="command">The query XML element See <see cref="XmlElement"/> for more information.</param>
        protected abstract void BuildCommandParams(XmlDocument doc, XmlElement command);

        /// <summary>
        /// Parses the results from the HTTP request.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result. See <see cref="HttpRequestResult"/> for more information.</param>
        /// <returns><typeparam name="T">The parsed result object. See <see cref="IceWarpResponse"/> for more information.</typeparam></returns>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        public abstract T FromHttpRequestResult(HttpRequestResult httpRequestResult);

        /// <summary>
        /// Generates the XML for the request.
        /// </summary>
        /// <returns>The XML document. See <see cref="XmlDocument"/> for more information.</returns>
        public XmlDocument ToXml()
        {
            var doc = new XmlDocument();

            var command = CreateCommand(doc, SessionId);

            XmlHelper.AppendTextElement(command, XmlHelper.CommandNameTag, this.GetType().Name.ToLower());

            BuildCommandParams(doc, command);

            return doc;
        }

        /// <summary>
        /// Creates the CommandParams XML element.
        /// </summary>
        /// <param name="doc">The XML document. See <see cref="XmlDocument"/> for more information.</param>
        /// <returns>The CommandParams XML Element. See <see cref="XmlElement"/> for more information.</returns>
        protected XmlElement GetCommandParamsElement(XmlDocument doc)
        {
            return XmlHelper.CreateElement(doc, XmlHelper.CommandParamsTag);
        }

        /// <summary>
        /// Creates the IceWarp API Command
        /// </summary>
        /// <param name="doc">The XML document. See <see cref="XmlDocument"/> for more information.</param>
        /// <param name="sessionId">The API sid (session id).</param>
        /// <returns>The Command XML Element. See <see cref="XmlElement"/> for more information.</returns>
        private XmlElement CreateCommand(XmlDocument doc, string sessionId)
        {
            var root = doc.CreateElement(XmlHelper.IqTag);
            root.SetAttribute(XmlHelper.TypeAttribute, XmlHelper.TypeGetValue);
            if (!String.IsNullOrEmpty(sessionId))
            {
                root.SetAttribute(XmlHelper.SidAttribute, sessionId);
            }
            doc.AppendChild(root);

            var query = XmlHelper.CreateElement(doc, XmlHelper.QueryTag, XmlHelper.Xmlns);
            root.AppendChild(query);

            return query;
        }
    }
}
