using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Used to filter the list of properties in server / domain / account API console.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyListFilter">https://www.icewarp.co.uk/api/#TPropertyListFilter</see></para>
    /// </summary>
    public class TPropertyListFilter : RpcBaseClass
    {
        /// <summary>
        /// Supports wildcards, used agains property name , value and comment
        /// </summary>
        public string Mask { get; set; }
        /// <summary>
        /// If the group list is specified, only properties in the group list is returned
        /// </summary>
        public TPropertyStringList Groups { get; set; }
        /// <summary>
        /// Specifies if the cached property list should be cleared or not
        /// </summary>
        public bool Clear { get; set; }

        /// <inheritdoc />
        public TPropertyListFilter(){ }

        /// <inheritdoc />
        public TPropertyListFilter(XmlNode node)
        {
            if (node != null)
            {
                Mask = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Mask)));
                Groups = new TPropertyStringList(node.GetSingleNode(ClassHelper.GetMemberName(() => Groups)));
                Clear = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => Clear)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Mask), Mask);
            if (Groups != null)
            {
                element.AppendChild(Groups.BuildXmlElement(doc, ClassHelper.GetMemberName(() => Groups)));
            }
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Clear), Clear);

            return element;
        }
    }
}
