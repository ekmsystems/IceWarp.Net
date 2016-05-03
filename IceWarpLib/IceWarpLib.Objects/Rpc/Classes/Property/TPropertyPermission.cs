using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Property
{
    /// <summary>
    /// Defines a permissions for API property.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyPermission">https://www.icewarp.co.uk/api/#TPropertyPermission</see></para>
    /// </summary>
    public class TPropertyPermission : RpcBaseClass
    {
        /// <summary>
        /// Property ID
        /// </summary>
        public int Prop { get; set; }
        /// <summary>
        /// Property Permission. See <see cref="TPermission"/>
        /// </summary>
        public TPermission Perm { get; set; }

        /// <inheritdoc />
        public TPropertyPermission() { }

        /// <inheritdoc />
        public TPropertyPermission(XmlNode node)
        {
            if (node != null)
            {
                Prop = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Prop)));
                Perm = (TPermission)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => Perm)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Prop), Prop.ToString());
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Perm), Perm.ToString());

            return element;
        }
    }
}
