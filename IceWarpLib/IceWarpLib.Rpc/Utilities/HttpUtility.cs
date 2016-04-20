using System;
using System.IO;
using System.Net;
using System.Text;
using IceWarpLib.Rpc.Exceptions;

namespace IceWarpLib.Rpc.Utilities
{
    public interface IHttpUtility
    {
        /// <summary>
        /// Sends a HTTP POST request with the Content Type set to application/xml
        /// </summary>
        /// <param name="url">The URL POSTing to.</param>
        /// <param name="request">The XML string request.</param>
        /// <returns>See <see cref="HttpRequestResult"/> for more information.</returns>
        /// <exception cref="IceWarpApiException"> thrown if an error occurs.</exception>
        HttpRequestResult PostAsXml(string url, string request);
    }

    public class HttpUtility : IHttpUtility
    {
        /// <summary>
        /// Sends a HTTP POST request with the Content Type set to application/xml
        /// </summary>
        /// <param name="url">The URL POSTing to.</param>
        /// <param name="request">The XML string request.</param>
        /// <returns>See <see cref="HttpRequestResult"/> for more information.</returns>
        /// <exception cref="IceWarpApiException"> thrown if an error occurs.</exception>
        public HttpRequestResult PostAsXml(string url, string request)
        {
            var result = new HttpRequestResult
            {
                HttpMethod = "POST",
                ContentType = "application/xml",
                Url = url,
                Request = request
            };

            return sendRequest(result);
        }

        private HttpRequestResult sendRequest(HttpRequestResult request)
        {
            Exception caughtException = null;
            try
            {
                byte[] requestContent = Encoding.UTF8.GetBytes(request.Request);

                WebRequest webRequest = WebRequest.Create(request.Url);
                webRequest.Method = request.HttpMethod;
                webRequest.ContentType = request.ContentType;
                webRequest.ContentLength = requestContent.Length;

                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(requestContent, 0, requestContent.Length);
                }

                using (WebResponse response = webRequest.GetResponse())
                {
                    request.HttpStatus = ((HttpWebResponse)response).StatusDescription;
                    using (StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
                    {
                        request.Response = responseStream.ReadToEnd();
                    }
                }
                request.Success = true;
            }
            catch (WebException exception)
            {
                request.Success = false;
                request.Response = exception.Message;
                request.HttpStatus = exception.Status == WebExceptionStatus.ProtocolError
                    ? ((HttpWebResponse)exception.Response).StatusDescription
                    : exception.Status.ToString();
                caughtException = exception;
            }
            catch (Exception exception)
            {
                request.Success = false;
                request.Response = exception.Message;
                caughtException = exception;
            }
            if (caughtException != null)
            {
                throw new IceWarpApiException(request, caughtException);
            }
            return request;
        }
    }
}
