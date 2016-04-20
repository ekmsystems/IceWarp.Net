﻿using System.Collections.Generic;
using System.Xml;
using IceWarpObjects.Helpers;
using IceWarpObjects.Rpc.Classes;
using IceWarpRpc.Utilities;

namespace IceWarpRpc.Responses
{
    /// <summary>
    /// Represents the list of properties returned in API Console
    /// </summary>
    public class TPropertyInfoListResponse : IceWarpResponse
    {
        /// <summary>
        /// Current offset in the list.
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// Overall count of domains in the list.
        /// </summary>
        public int OverallCount { get; set; }
        /// <summary>
        /// List Of TPropertyInfo. See <see cref="TPropertyInfo"/> for more information.
        /// </summary>
        public List<TPropertyInfo> Items { get; set; }
        
        public TPropertyInfoListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyInfo>();
            if (node != null)
            {
                Offset = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("Offset"));
                OverallCount = Extensions.GetNodeInnerTextAsInt(node.GetSingleNode("OverallCount"));
                var items = node.SelectNodes("item");
                if (items != null)
                {
                    foreach (XmlNode item in items)
                    {
                        Items.Add(new TPropertyInfo(item));
                    }
                }
            }
        }
    }
}
