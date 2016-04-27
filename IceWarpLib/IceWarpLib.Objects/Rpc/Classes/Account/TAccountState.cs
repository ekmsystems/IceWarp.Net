using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// State of IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TAccountState">https://www.icewarp.co.uk/api/#TAccountState</see></para>
    /// </summary>
    public class TAccountState : TPropertyVal
    {
        /// <summary>
        /// State value
        /// </summary>
        public TUserState State { get; set; }

        /// <inheritdoc />
        public TAccountState()
        {
        }

        /// <inheritdoc />
        public TAccountState(XmlNode node)
        {
            if (node != null)
            {
                State = (TUserState)Extensions.GetNodeInnerTextAsInt(node.GetSingleNode(ClassHelper.GetMemberName(() => State)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, XmlHelper.ClassNameTag, ClassName);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => State), State);

            return element;
        }
    }
}
