namespace IceWarpLib.Rpc.Utilities
{
    /// <summary>
    /// A HTTP request result.
    /// </summary>
    public class HttpRequestResult
    {
        /// <summary>
        /// The request URL.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The request HTTP Method.
        /// </summary>
        public string HttpMethod { get; set; }
        /// <summary>
        /// The request Content Type.
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// The request HTTP Status.
        /// </summary>
        public string HttpStatus { get; set; }
        /// <summary>
        /// The request.
        /// </summary>
        public string Request { get; set; }
        /// <summary>
        /// The response.
        /// </summary>
        public string Response { get; set; }
        /// <summary>
        /// True of the request was successful.
        /// </summary>
        public bool Success { get; set; }
    }
}
