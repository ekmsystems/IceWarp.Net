using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Represents class TServiceBasicStatistics.
    /// <para><see href="https://www.icewarp.co.uk/api/#TServiceBasicStatistics">https://www.icewarp.co.uk/api/#TServiceBasicStatistics</see></para>
    /// </summary>
    public class TServiceBasicStatistics : TServiceStatistics
    {
        /// <inheritdoc />
        public TServiceBasicStatistics()
        {
        }

        /// <inheritdoc />
        public TServiceBasicStatistics(XmlNode node)
        {
            if (node != null)
            {
                ProcessNode(node);
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            AppendBaseElements(element);

            return element;
        }
    }
}
