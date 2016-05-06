using System;
using System.Collections.Generic;
using System.Reflection;
using IceWarpLib.Objects.Helpers;
using IceWarpLib.Objects.Rpc.Classes.Property;

namespace IceWarpLib.Objects.Com.Objects
{
    /// <summary>
    /// Base class for an IceWarp API COM Object
    /// </summary>
    public abstract class ComBaseClass
    {
        /// <summary>
        /// Empty Constructor
        /// </summary>
        protected ComBaseClass() { }

        /// <summary>
        /// Creates a new instance from a list of TPropertyValue. See <see cref="TPropertyValue"/> for more information.
        /// </summary>
        /// <param name="valueList">A list of property values. <see cref="List{TPropertyValue}"/></param>
        protected ComBaseClass(List<TPropertyValue> valueList)
        {
            var properties = ClassHelper.GetProperites(this.GetType(), BindingFlags.Instance | BindingFlags.Public);
            foreach (var property in properties)
            {
                //bool?
                //char?
                //DateTime?
                //int?
                //Enum?
                //string
                //List<string>

                if (property.PropertyType == typeof(bool))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsBool(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(bool?))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsNullableBool(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(char))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsChar(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(char?))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsNullableChar(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(int))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsInt(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(int?))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsNullableInt(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(DateTime))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsDateTime(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(DateTime?))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsNullableDateTime(valueList, property.Name));
                }
                else if (property.PropertyType.IsEnum)
                {
                    var enumVal = TPropertyValHelper.GetPropertyValAsInt(valueList, property.Name);
                    var enumType = Nullable.GetUnderlyingType(property.PropertyType);
                    if (Enum.IsDefined(enumType, enumVal))
                    {
                        property.SetValue(this, Enum.ToObject(enumType, enumVal));
                    }
                }
                else if (property.PropertyType.IsNullableEnum())
                {
                    var enumVal = TPropertyValHelper.GetPropertyValAsNullableInt(valueList, property.Name);
                    if (enumVal.HasValue)
                    {
                        var enumType = Nullable.GetUnderlyingType(property.PropertyType);
                        if (Enum.IsDefined(enumType, enumVal))
                        {
                            property.SetValue(this, Enum.ToObject(enumType, enumVal));
                        }
                    }
                }
                else if (property.PropertyType == typeof(string))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsString(valueList, property.Name));
                }
                else if (property.PropertyType == typeof(List<string>))
                {
                    property.SetValue(this, TPropertyValHelper.GetPropertyValAsStringList(valueList, property.Name));
                }
            }
        }

        /// <summary>
        /// Returns a list of public property names.
        /// </summary>
        /// <returns>The public property names.</returns>
        public List<string> PropertyNames()
        {
            return ClassHelper.GetPropertyNames(this.GetType(), BindingFlags.Instance | BindingFlags.Public);
        }
    }
}
