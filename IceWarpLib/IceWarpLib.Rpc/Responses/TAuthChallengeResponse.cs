using System;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Returns current hash(RSA public modulus) and timestamp used in authorization.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAuthChallenge">https://www.icewarp.co.uk/api/#TAuthChallenge</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAuthChallenge">https://www.icewarp.co.uk/api/#GetAuthChallenge</seealso></para>
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

        /// <inheritdoc />
        public TAuthChallengeResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            if (node != null)
            {
                HashId = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HashId)));
                Timestamp = Extensions.UnixTimeStampToDateTime(Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Timestamp))));
            }
        }
    }
}
