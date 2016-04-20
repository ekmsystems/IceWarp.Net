using System.Xml;
using IceWarpObjects.Helpers;

namespace IceWarpObjects.Rpc.Classes
{
    /// <summary>
    /// Basic informations about IceWarp folder object, is used in folder listing
    /// </summary>
    public class TFolderInfo : BaseClass
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
        
        public TFolderInfo()
        {
            SubFolders = new TFolderInfoList();
        }

        /// <summary>
        /// Creates new instance from an XML node. See <see cref="XmlNode"/> for more information.
        /// </summary>
        /// <param name="node">The Xml node. See <see cref="XmlNode"/> for more information.</param>
        public TFolderInfo(XmlNode node)
        {
            if (node != null)
            {
                Name = Extensions.GetNodeInnerText(node.GetSingleNode("Name"));
                ID = Extensions.GetNodeInnerText(node.GetSingleNode("ID"));
                FolderType = Extensions.GetNodeInnerText(node.GetSingleNode("FolderType"));
                DefaultType = Extensions.GetNodeInnerText(node.GetSingleNode("DefaultType"));
                SubFolders = new TFolderInfoList(node.GetSingleNode("SubFolders"));
            }
        }

        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            XmlHelper.AppendTextElement(element, "Name", Name);
            XmlHelper.AppendTextElement(element, "ID", ID);
            XmlHelper.AppendTextElement(element, "FolderType", FolderType);
            XmlHelper.AppendTextElement(element, "DefaultType", DefaultType);
            element.AppendChild(SubFolders.BuildXmlElement(doc, Name));
            
            return element;
        }
    }
}
