using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace IceWarpLib.Objects.Helpers
{
    public static class SerializationHelper
    {
        public static string XmlSerialize(object item)
        {
            string serializedString = string.Empty;
            XmlSerializer xmlSerializer = new XmlSerializer(item.GetType());
            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, item);
                serializedString = stringWriter.ToString();
                stringWriter.Flush();
            }
            return serializedString;
        }

        public static T XmlDeserialize<T>(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                using (StringReader stringReader = new StringReader(item))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(stringReader);
                }
            }
            return default(T);
        }

        public static string JsonSerialize(object item)
        {
            return item != null ? JsonConvert.SerializeObject(item) : "";
        }

        public static T JsonDeserialize<T>(string item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                return JsonConvert.DeserializeObject<T>(item);
            }
            return default(T);
        }
    }
}
