using System;
using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Com.Enums;
using IceWarpLib.Objects.Com.Objects;
using IceWarpLib.Objects.Com.Objects.AccountTypes;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Enums;

namespace IceWarpLib.Objects.Helpers
{
    public static class TPropertyValHelper
    {
        public static Account GetConcreteAccountType(List<TPropertyValue> valueList)
        {
            var accountType = GetPropertyValAsNullableEnum<AccountType>(valueList, "U_Type");
            if (accountType.HasValue)
            {
                try
                {
                    switch (accountType.Value)
                    {
                        case AccountType.User:
                            return new User(valueList);
                        case AccountType.MailingList:
                            return new MailingList(valueList);
                        case AccountType.Executable:
                            return new Executable(valueList);
                        case AccountType.Notification:
                            return new Notification(valueList);
                        case AccountType.StaticRoute:
                            return new StaticRoute(valueList);
                        case AccountType.Catalog:
                            return new Catalog(valueList);
                        case AccountType.ListServer:
                            return new ListServer();
                        case AccountType.Group:
                            return new Group(valueList);
                        case AccountType.Resource:
                            return new Resource(valueList);
                        default:
                            break;
                    }
                }
                catch (Exception e){}
            }
            return null;
        }

        public static TPropertyValue GetTPropertyValue(List<TPropertyValue> valueList, string propName)
        {
            return valueList.FirstOrDefault(x => x.APIProperty.PropName.ToLower() == propName.ToLower());
        }

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

        public static bool GetPropertyValAsBool(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
            return GetPropertyValAsBool(propertyValue);
        }

        public static bool GetPropertyValAsBool(TPropertyValue propertyValue)
        {
            var propertyVal = GetFromTPropertyValue<TPropertyString>(propertyValue);
            if (propertyVal != null && !String.IsNullOrEmpty(propertyVal.Val))
            {
                return propertyVal.Val == "1";
            }
            return default(bool);
        }

        public static bool? GetPropertyValAsNullableBool(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
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
            var propertyValue = GetTPropertyValue(valueList, propName);
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
            var propertyValue = GetTPropertyValue(valueList, propName);
            return GetPropertyValAsNullableChar(propertyValue);
        }

        public static char? GetPropertyValAsNullableChar(TPropertyValue propertyValue)
        {
            var value = GetPropertyValAsString(propertyValue);
            if (!String.IsNullOrEmpty(value))
                return value[0];
            return null;
        }

        public static DateTime GetPropertyValAsDateTime(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
            return GetPropertyValAsDateTime(propertyValue);
        }

        public static DateTime GetPropertyValAsDateTime(TPropertyValue propertyValue)
        {
            var value = GetPropertyValAsString(propertyValue);
            if (!String.IsNullOrEmpty(value))
            {
                try
                {
                    return DateTime.Parse(value);
                }
                catch (Exception e) { }
            }
            return default(DateTime);
        }

        public static DateTime? GetPropertyValAsNullableDateTime(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
            return GetPropertyValAsNullableDateTime(propertyValue);
        }

        public static DateTime? GetPropertyValAsNullableDateTime(TPropertyValue propertyValue)
        {
            var value = GetPropertyValAsString(propertyValue);
            if (!String.IsNullOrEmpty(value))
            {
                try
                {
                    return DateTime.Parse(value);
                }
                catch (Exception e) { }
            }
            return null;
        }

        public static int GetPropertyValAsInt(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
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
            return default(int);
        }

        public static int? GetPropertyValAsNullableInt(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
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
            var propertyValue = GetTPropertyValue(valueList, propName);
            return EnumHelper.Parse<T>(GetPropertyValAsInt(propertyValue));
        }

        public static T GetPropertyValAsEnum<T>(TPropertyValue propertyValue) where T : struct
        {
            return EnumHelper.Parse<T>(GetPropertyValAsInt(propertyValue));
        }

        public static T? GetPropertyValAsNullableEnum<T>(List<TPropertyValue> valueList, string propName) where T : struct
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
            return EnumHelper.ParseNullable<T>(GetPropertyValAsNullableInt(propertyValue));
        }

        public static T? GetPropertyValAsNullableEnum<T>(TPropertyValue propertyValue) where T : struct
        {
            return EnumHelper.ParseNullable<T>(GetPropertyValAsNullableInt(propertyValue));
        }

        public static string GetPropertyValAsString(List<TPropertyValue> valueList, string propName)
        {
            var propertyValue = GetTPropertyValue(valueList, propName);
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
            var propertyValue = GetTPropertyValue(valueList, propName);
            var propertyVal = GetFromTPropertyValue<TPropertyStringList>(propertyValue);
            if (propertyVal != null)
            {
                return propertyVal.Val;
            }
            return new List<string>();
        }
        
        public static TPropertyValue SetPropertyValue(bool value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            tPropertyValue.PropertyVal = new TPropertyString { Val = value.ToBitString() };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(bool? value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            if(value.HasValue)
                tPropertyValue.PropertyVal = new TPropertyString { Val = value.Value.ToBitString() };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(char value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            tPropertyValue.PropertyVal = new TPropertyString { Val = new String(new char[] { value }) };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(char? value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            if (value.HasValue)
                tPropertyValue.PropertyVal = new TPropertyString { Val = new String(new char[] { value.Value }) };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(int value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            tPropertyValue.PropertyVal = new TPropertyString { Val = value.ToString() };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(int? value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            if (value.HasValue)
                tPropertyValue.PropertyVal = new TPropertyString { Val = value.Value.ToString() };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(DateTime value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            tPropertyValue.PropertyVal = new TPropertyString { Val = value.ToString("yyyy/MM/dd") };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(DateTime? value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            if (value.HasValue)
                tPropertyValue.PropertyVal = new TPropertyString { Val = value.Value.ToString("yyyy/MM/dd") };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(string value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            tPropertyValue.PropertyVal = new TPropertyString { Val = value };
            return tPropertyValue;
        }

        public static TPropertyValue SetPropertyValue(List<string> value, string propName)
        {
            var tPropertyValue = buildTPropertyValue(propName);
            var list = new TPropertyStringList();
            if (value != null)
            {
                foreach (var val in value)
                {
                    list.Val.Add(val);
                }
            }
            tPropertyValue.PropertyVal = list;
            return tPropertyValue;
        }

        private static TPropertyValue buildTPropertyValue(string propName)
        {
            return buildTPropertyValue(propName, TPermission.ReadWrite);
        }

        private static TPropertyValue buildTPropertyValue(string propName, TPermission permission)
        {
            return new TPropertyValue
            {
                APIProperty = new TAPIProperty { PropName = propName },
                PropertyRight = permission
            };
        }
    }
}
