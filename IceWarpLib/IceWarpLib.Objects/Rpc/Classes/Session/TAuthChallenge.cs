using System;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Rpc.Classes.Session
{
    /// <summary>
    /// Returns current hash(RSA public modulus) and timestamp used in authorization.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAuthChallenge">https://www.icewarp.co.uk/api/#TAuthChallenge</see></para>
    /// </summary>
    public class TAuthChallenge : TPropertyVal
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
        public TAuthChallenge()
        {
        }

        /// <inheritdoc />
        public TAuthChallenge(XmlNode node)
        {
            if (node != null)
            {
                HashId = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => HashId)));
                Timestamp = Extensions.UnixTimeStampToDateTime(Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Timestamp))));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => HashId), HashId);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Timestamp), Timestamp.ToUnixTimeStamp());

            return element;
        }
    }
}
