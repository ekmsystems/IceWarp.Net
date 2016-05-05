using System;
using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Helpers
{
    public static class TPropertyValHelper
    {
        public static T GetFromTPropertyValue<T>(TPropertyValue propertyValue) where T : TPropertyVal
        {
            if (propertyValue != null &&
                propertyValue.PropertyVal != null &&
                propertyValue.PropertyVal.GetType() == typeof(T))
            {
                return (T)propertyValue.PropertyVal;
            }
            return null;
        }

        public static string GetPropertyValAsString(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsString(propertyValue);
        }

        public static string GetPropertyValAsString(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null)
            {
                return propertyVal.Val;
            }
            return null;
        }

        public static List<string> GetPropertyValAsStringList(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            var propertyVal = GetFromTPropertyValue<TPropertyStringList>(propertyValue);
            if (propertyVal != null)
            {
                return propertyVal.Val;
            }
            return new List<string>();
        } 

        public static bool GetPropertyValAsBool(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsBool(propertyValue);
        }

        public static bool GetPropertyValAsBool(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null && !String.IsNullOrEmpty(propertyVal.Val))
            {
                return propertyVal.Val == "1";
            }
            return false;
        }

        public static bool? GetPropertyValAsNullableBool(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsNullableBool(propertyValue);
        }

        public static bool? GetPropertyValAsNullableBool(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null && !String.IsNullOrEmpty(propertyVal.Val))
            {
                return propertyVal.Val == "1";
            }
            return null;
        }

        public static char GetPropertyValAsChar(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsChar(propertyValue);
        }

        public static char GetPropertyValAsChar(TPropertyValue propertyValue)
        {
            var value = GetPropertyValAsString(propertyValue);
            if (!String.IsNullOrEmpty(value))
                return value[0];
            return default(char);
        }

        public static char? GetPropertyValAsNullableChar(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsNullableChar(propertyValue);
        }

        public static char? GetPropertyValAsNullableChar(TPropertyValue propertyValue)
        {
            var value = GetPropertyValAsString(propertyValue);
            if (!String.IsNullOrEmpty(value))
                return value[0];
            return null;
        }

        public static int GetPropertyValAsInt(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsInt(propertyValue);
        }

        public static int GetPropertyValAsInt(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null && !String.IsNullOrEmpty(propertyVal.Val))
            {
                try
                {
                    return int.Parse(propertyVal.Val);
                }
                catch (Exception e) { }
            }
            return 0;
        }

        public static int? GetPropertyValAsNullableInt(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return GetPropertyValAsNullableInt(propertyValue);
        }

        public static int? GetPropertyValAsNullableInt(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null && !String.IsNullOrEmpty(propertyVal.Val))
            {
                try
                {
                    return int.Parse(propertyVal.Val);
                }
                catch (Exception e) { }
            }
            return null;
        }

        public static T GetPropertyValAsEnum<T>(List<TPropertyValue> valueList, string propName) where T : struct
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return EnumHelper.Parse<T>(GetPropertyValAsInt(propertyValue));
        }

        public static T GetPropertyValAsEnum<T>(TPropertyValue propertyValue) where T : struct
        {
            return EnumHelper.Parse<T>(GetPropertyValAsInt(propertyValue));
        }

        public static T? GetPropertyValAsNullableEnum<T>(List<TPropertyValue> valueList, string propName) where T : struct
        {
            var propertyValue = valueList.FirstOrDefault(x => x.APIProperty.PropName == propName);
            return EnumHelper.ParseNullable<T>(GetPropertyValAsNullableInt(propertyValue));
        }

        public static T? GetPropertyValAsNullableEnum<T>(TPropertyValue propertyValue) where T : struct
        {
            return EnumHelper.ParseNullable<T>(GetPropertyValAsNullableInt(propertyValue));
        }
    }
}
