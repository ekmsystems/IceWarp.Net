using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Services
{
    /// <summary>
    /// Traffic chart data value.
    /// <para><see href="https://www.icewarp.co.uk/api/#TSCItm">https://www.icewarp.co.uk/api/#TSCItm</see></para>
    /// </summary>
    public class TSCItm : RpcBaseClass
    {
        /// <summary>
        /// Value
        /// </summary>
        public float V { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public string D { get; set; }

        /// <inheritdoc />
        public TSCItm()
        {
        }

        /// <inheritdoc />
        public TSCItm(XmlNode node)
            : base(node)
        {
            if (node != null)
            {
                V = Extensions.GetNodeInnerTextAsFloat(node.GetSingleNode(ClassHelper.GetMemberName(() => V)));
                D = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => D)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => V), V);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => D), D);

            return element;
        }
    }
}
