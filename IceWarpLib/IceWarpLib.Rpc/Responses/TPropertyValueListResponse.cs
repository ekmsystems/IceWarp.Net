using System.Collections.Generic;
using System.Xml;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Rpc.Utilities;

namespace IceWarpLib.Rpc.Responses
{
    /// <summary>
    /// Represents class TPropertyValueList.
    /// <para><see href="https://www.icewarp.co.uk/api/#TPropertyValueList">https://www.icewarp.co.uk/api/#TPropertyValueList</see></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetAccountProperties">https://www.icewarp.co.uk/api/#GetAccountProperties</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetDeviceProperties">https://www.icewarp.co.uk/api/#GetDeviceProperties</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetDomainProperties">https://www.icewarp.co.uk/api/#GetDomainProperties</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetServerProperties">https://www.icewarp.co.uk/api/#GetServerProperties</seealso></para>
    /// <para><seealso href="https://www.icewarp.co.uk/api/#GetStatisticsProperties">https://www.icewarp.co.uk/api/#GetStatisticsProperties</seealso></para>
    /// </summary>
    public class TPropertyValueListResponse : IceWarpResponse
    {
        /// <summary>
        /// List Of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        public List<TPropertyValue> Items { get; set; }

        /// <inheritdoc />
        public TPropertyValueListResponse(HttpRequestResult httpRequestResult)
            : base(httpRequestResult)
        {
        }

        /// <inheritdoc />
        public override void ProcessResultNode(XmlNode node)
        {
            Items = new List<TPropertyValue>();
            if (node != null)
            {
                var items = node.GetNodes(XmlHelper.ItemTag);
                foreach (XmlNode item in items)
                {
                    Items.Add(new TPropertyValue(item));
                }
            }
        }
    }
}
