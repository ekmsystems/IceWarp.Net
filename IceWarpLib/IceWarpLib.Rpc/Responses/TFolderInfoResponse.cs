﻿using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
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
                Name = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => Name)));
                ID = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => ID)));
                FolderType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => FolderType)));
                DefaultType = Extensions.GetNodeInnerText(node.GetSingleNode(ClassHelper.GetMemberName(() => DefaultType)));
                SubFolders = new TFolderInfoList(node.GetSingleNode(ClassHelper.GetMemberName(() => SubFolders)));
            }
        }
    }
}
