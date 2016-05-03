using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Pair of API Property and its comment ( used to create translation XML ).
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyTranslateInfo">https://www.icewarp.co.uk/api/#TPropertyTranslateInfo</see></para>
    /// </summary>
    public class TPropertyTranslateInfo : RpcBaseClass
    {
        /// <summary>
        /// Represents class property TPropertyTranslateInfo.Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents class property TPropertyTranslateInfo.Comment
        /// </summary>
        public string Comment { get; set; }

        /// <inheritdoc />
        public TPropertyTranslateInfo() { }

        /// <inheritdoc />
        public TPropertyTranslateInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                Comment = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Comment)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Comment), Comment);
            return element;
        }
    }
}
