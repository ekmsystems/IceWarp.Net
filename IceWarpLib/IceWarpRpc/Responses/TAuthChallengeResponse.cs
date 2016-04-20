using System;
using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Responses
{
    /// <summary>
    /// Returns current hash(RSA public modulus) and timestamp used in authorization
    /// </summary>
    public class TAuthChallengeResponse : IceWarpResponse
    {
        /// <summary>
        /// Hash ( public RSA key modulus )
        /// </summary>
        public string HashId { get; set; }
        /// <summary>
        /// Time of the hash creation
        /// </summary>
        public DateTime Timestamp { get; set; }
        
        public TAuthChallengeResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                HashId = Extensions.GetNodeInnerText(node.GetSingleNode("HashId"));
                Timestamp = Extensions.UnixTimeStampToDateTime(Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Timestamp")));
            }
        }
    }
}
