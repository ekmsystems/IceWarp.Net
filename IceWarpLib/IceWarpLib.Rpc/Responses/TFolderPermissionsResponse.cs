using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// List of permissions related to specific folder in IceWarp account
    /// </summary>
    public class TFolderPermissionsResponse : IceWarpResponse
    {
        /// <summary>
        /// Inherited rights from higher level
        /// </summary>
        public bool IsInherited { get; set; }
        /// <summary>
        /// List Of TFolderPermissionsItem
        /// </summary>
        public List<TFolderPermissionsItem> Items { get; set; }

        public TFolderPermissionsResponse(HttpRequestResult httpRequestResult) 
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TFolderPermissionsItem>();
            if (node != null)
            {
                IsInherited = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode("IsInherited"));
                var items = node.GetNodes("item");
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TFolderPermissionsItem(item));
                    }
                }
            }
        }
    }
}
