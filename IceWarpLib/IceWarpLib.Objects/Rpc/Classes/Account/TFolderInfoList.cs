using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;

namespace IceWarpLib.Objects.Rpc.Classes.Account
{
    /// <summary>
    /// Represents the list of folders in IceWarp account.
    /// <para><see href="https://www.icewarp.co.uk/api/#TFolderInfoList">https://www.icewarp.co.uk/api/#TFolderInfoList</see></para>
    /// </summary>
    public class TFolderInfoList : RpcBaseClass
    {
        /// <summary>
        /// List Of TFolderInfo. See <see cref="List{TFolderInfo}"/> for more information.
        /// </summary>
        public List<TFolderInfo> Items { get; set; }

        /// <inheritdoc />
        public TFolderInfoList()
        {
            Items = new List<TFolderInfo>();
        }

        /// <inheritdoc />
        public TFolderInfoList(XmlNode node)
        {
            Items = new List<TFolderInfo>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TFolderInfo(item));
                }
            }
        }

        /// <inheritdoc />
        public override XmlElement BuildXmlElement(XmlDocument doc, string name)
        {
            XmlElement element = XmlHelper.CreateElement(doc, name);

            foreach (var item in Items)
            {
                element.AppendChild(item.BuildXmlElement(doc, XmlHelper.ItemTag));
            }

            return element;
        }
    }
}
