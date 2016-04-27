using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// List of TPropertyRight.
    /// <para><see href="https://www.icewarp.co.uk/api/#GetMyDomainRigths">https://www.icewarp.co.uk/api/#GetMyDomainRigths</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#TPropertyRightList">https://www.icewarp.co.uk/api/#TPropertyRightList</seealso></para>
    /// </summary>
    public class TPropertyRightListResponse : IceWarpResponse
    {
        /// <summary>
        /// List Of TPropertyRight. See <see cref="TPropertyRight"/> for more information.
        /// </summary>
        public List<TPropertyRight> Items { get; set; }

        /// <inheritdoc />
        public TPropertyRightListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyRight>();

            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyRight(item));
                    }
                }
            }
        }
    }
}
