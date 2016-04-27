using System;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Exceptions;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Base class for an API response.
    /// </summary>
    public abstract class IceWarpResponse
    {
        /// <summary>
        /// The HTTP request result. See <see cref="HttpRequestResult"/> for more information.
        /// </summary>
        public HttpRequestResult HttpRequestResult { get; set; }

        /// <summary>
        /// The type of request result i.e. result, error.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The Session ID of the authenticated user (sid).
        /// </summary>
        public string SessionId { get; set; }

        private XmlDocument _responseXml = null;

        /// <summary>
        /// Creates an IceWarpResponse from the HTTP request result.
        /// </summary>
        /// <param name="httpRequestResult">The HTTP request result. See <see cref="HttpRequestResult"/>. for more information.</param>
        /// <exception cref="ProcessResponseException"> Thrown if HttpRequestResult is null, if HttpRequestResult.Response is null or empty or an exception occurs when loading the XML.</exception>
        /// <exception cref="IceWarpErrorException">Thrown if IceWarp returned and error.</exception>
        protected IceWarpResponse(HttpRequestResult httpRequestResult)
        {
            HttpRequestResult = httpRequestResult;
            ProcessRequestResult();
        }

        /// <summary>
        /// Base method to process the result node in the responses XML.
        /// </summary>
        /// <param name="node">The result XML node. See <see cref="XmlNode"/> for more information.</param>
        public abstract void ProcessResultNode(XmlNode node);

        private void ProcessRequestResult()
        {
            if (HttpRequestResult == null)
            {
                throw new ProcessResponseException("HttpRequestResult is null");
            }

            if (String.IsNullOrEmpty(HttpRequestResult.Response))
            {
                throw new ProcessResponseException("Response is null or empty", HttpRequestResult);
            }

            _responseXml = new XmlDocument();
            try
            {
                _responseXml.LoadXml(HttpRequestResult.Response);
            }
            catch (Exception exception)
            {
                throw new ProcessResponseException(HttpRequestResult, exception);
            }

            ProcessDocumentElement(_responseXml.DocumentElement);
            
            var documentElement = _responseXml.DocumentElement.RemoveAllNamespaces();

            if (Type != "error")
            {
                ProcessResultNode(documentElement.SelectSingleNode(XmlHelper.ResultXPath));
            }
            else
            {
                var errorNode = documentElement.SelectSingleNode(XmlHelper.ErrorXPath);
                if (errorNode != null && errorNode.Attributes != null)
                {
                    var uid = errorNode.Attributes[XmlHelper.ErrorIdAttribute];
                    if (uid != null)
                    {
                        throw new IceWarpErrorException(uid.Value, HttpRequestResult);
                    }
                    throw new IceWarpErrorException("Unknown Error", HttpRequestResult);
                }
            }
        }

        private void ProcessDocumentElement(XmlNode documentElement)
        {
            if (documentElement != null)
            {
                var typeAttr = documentElement.Attributes[XmlHelper.TypeAttribute];
                if (typeAttr != null)
                {
                    Type = typeAttr.Value;
                }
                var sidAttr = documentElement.Attributes[XmlHelper.SidAttribute];
                if (sidAttr != null)
                {
                    SessionId = sidAttr.Value;
                }
            }
        }
    }
}
