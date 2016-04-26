using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// List Of TPropertyRight
    /// </summary>
    public class TPropertyRightListResponse : IceWarpResponse
    {
        /// <summary>
        /// List Of TPropertyRight. See <see cref="TPropertyRight"/> for more information.
        /// </summary>
        public List<TPropertyRight> Items { get; set; }
        
        public TPropertyRightListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyRight>();

            if (node != null)
            {
                var items = node.GetNodes("item");
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
