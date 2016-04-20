using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents class TPropertyValueList
    /// </summary>
    public class TPropertyValueListResponse : IceWarpResponse
    {
        /// <summary>
        /// List Of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        public List<TPropertyValue> Items { get; set; }

        public TPropertyValueListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyValue>();
            if (node != null)
            {
                var items = node.GetNodes("item");
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyValue(item));
                }
            }
        }
    }
}
