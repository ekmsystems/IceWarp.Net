using System;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Responses;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc
{
    /// <summary>
    /// Abstract base class for an API command.
    /// </summary>
    /// <typeparam name="T">API method return type See <see cref="IceWarpResponse"/> for more information.</typeparam>
    public abstract class IceWarpCommand<T>
        where T : IceWarpResponse
    {
        private const string _xmlns = "admin:iq:rpc";

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
        public abstract T FromHttpRequestResult(HttpRequestResult httpRequestResult);

        protected XmlElement CreateCommand(XmlDocument doc, string sessionId)
        {
            var root = doc.CreateElement("iq");
            root.SetAttribute("type", "get");
            if (!String.IsNullOrEmpty(sessionId))
            {
                root.SetAttribute("sid", sessionId);
            }
            doc.AppendChild(root);

            var query = XmlHelper.CreateElement(doc, "query", _xmlns);
            root.AppendChild(query);

            return query;
        }

        /// <summary>
        /// Generates the XML for the request.
        /// </summary>
        /// <returns>The XML document See <see cref="XmlDocument"/> for more information.</returns>
        public XmlDocument ToXml()
        {
            var doc = new XmlDocument();

            var command = CreateCommand(doc, SessionId);

            XmlHelper.AppendTextElement(command, "commandname", this.GetType().Name.ToLower());

            BuildCommandParams(doc, command);

            return doc;
        }
    }
}
