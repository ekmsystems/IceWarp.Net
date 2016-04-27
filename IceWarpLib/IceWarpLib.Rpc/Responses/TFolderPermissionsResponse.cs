using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Account;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// List of permissions related to specific folder in IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TFolderPermissions">https://www.icewarp.co.uk/api/#TFolderPermissions</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAccountFolderPermissions">https://www.icewarp.co.uk/api/#GetAccountFolderPermissions</seealso></para>
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

        /// <inheritdoc />
        public TFolderPermissionsResponse(HttpRequestResult httpRequestResult) 
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TFolderPermissionsItem>();
            if (node != null)
            {
                IsInherited = Extensions.GetNodeInnerTextAsBool(node.GetSingleNode(ClassHelper.GetMemberName(() => IsInherited)));
                var items = node.GetNodes(XmlHelper.ItemTag);
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
