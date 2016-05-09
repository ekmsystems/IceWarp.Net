using System;
using System.Xml;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Helpers
{
    public static class Extensions
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public static double ToUnixTimeStamp(this DateTime dateTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;
            return unixDateTime;
        }

        public static string ToBitString(this bool value)
        {
            return value ? "1" : "0";
        }

        public static string ToBitString(this bool? value)
        {
            return value.HasValue ? value.Value ? "1" : "0" : "";
        }

        public static string ToEnumIntString(this Enum value)
        {
            if (value == null)
                return "";
            return value.ToString("d");
        }

        public static string GetNodeInnerText(XmlNode node)
        {
            if (node != null)
            {
                return node.InnerText;
            }
            return String.Empty;
        }

        public static bool GetNodeInnerTextAsBool(XmlNode node)
        {
            return GetNodeInnerTextAsInt(node) == 1;
        }

        public static int GetNodeInnerTextAsInt(XmlNode node)
        {
            if (node != null && !String.IsNullOrEmpty(node.InnerText))
            {
                return int.Parse(node.InnerText);
            }
            return 0;
        }

        public static int? GetNodeInnerTextAsNullableInt(XmlNode node)
        {
            if (node != null && !String.IsNullOrEmpty(node.InnerText))
            {
                try
                {
                    return int.Parse(node.InnerText);
                }
                catch(Exception e){}
            }
            return null;
        }

        public static float GetNodeInnerTextAsFloat(XmlNode node)
        {
            if (node != null && !String.IsNullOrEmpty(node.InnerText))
            {
                return float.Parse(node.InnerText);
            }
            return 0;
        }
    }
}
