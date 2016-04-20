using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Responses
{
    /// <summary>
    /// Basic informations about IceWarp folder object, is used in folder listing
    /// </summary>
    public class TFolderInfoResponse : IceWarpResponse
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
        
        public TFolderInfoResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
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
    }
}
