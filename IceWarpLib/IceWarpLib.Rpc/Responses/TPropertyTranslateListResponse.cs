using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Info list about server api variables - only names and comments.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyTranslateList">https://www.icewarp.co.uk/api/#TPropertyTranslateList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAllAPIVariables">https://www.icewarp.co.uk/api/#GetAllAPIVariables</seealso></para>
    /// </summary>
    public class TPropertyTranslateListResponse : IceWarpResponse
    {
        /// <summary>
        /// List Of TPropertyTranslateInfo. See <see cref="TPropertyTranslateInfo"/> for more information.
        /// </summary>
        public List<TPropertyTranslateInfo> Items { get; set; }

        /// <inheritdoc />
        public TPropertyTranslateListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyTranslateInfo>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyTranslateInfo(item));
                    }
                }
            }
        }
    }
}
