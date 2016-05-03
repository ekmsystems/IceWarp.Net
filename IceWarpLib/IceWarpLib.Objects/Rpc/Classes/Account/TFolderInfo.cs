using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Basic informations about IceWarp folder object, is used in folder listing.
    /// <para><see href="https://www.icewarp.co.uk/api/#TFolderInfo">https://www.icewarp.co.uk/api/#TFolderInfo</see></para>
    /// </summary>
    public class TFolderInfo : RpcBaseClass
    {
        /// <summary>
        /// Folder name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Folder ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Folder type
        /// </summary>
        public string FolderType { get; set; }
        /// <summary>
        /// Folder default type
        /// </summary>
        public string DefaultType { get; set; }
        /// <summary>
        /// List of subfolders in current folder
        /// </summary>
        public TFolderInfoList SubFolders { get; set; }

        /// <inheritdoc />
        public TFolderInfo()
        {
            SubFolders = new TFolderInfoList();
        }

        /// <inheritdoc />
        public TFolderInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                ID = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ID)));
                FolderType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FolderType)));
                DefaultType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DefaultType)));
                SubFolders = new TFolderInfoList(node.GetSingleNode(ClassHelper.GetMemberName(() => SubFolders)));
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => Name), Name);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => ID), ID);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => FolderType), FolderType);
            XmlHelper.AppendTextElement(element, ClassHelper.GetMemberName(() => DefaultType), DefaultType);
            element.AppendChild(SubFolders.BuildXmlElement(doc, Name));
            
            return element;
        }
    }
}
