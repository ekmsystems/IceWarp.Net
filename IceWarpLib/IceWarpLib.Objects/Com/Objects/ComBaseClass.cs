using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using IceWarpLib.Objects.Exceptions;
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
                    if (Enum.IsDefined(property.PropertyType, enumVal))
                    {
                        property.SetValue(this, Enum.ToObject(property.PropertyType, enumVal));
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
        /// Returns a list of TPropertyValue for updating IceWarp.
        /// <para>All public settable properties will be included unless they have a value of null.</para>
        /// </summary>
        /// <returns>The list of settable properties. See <see cref="List{TPropertyValue}"/></returns>
        public List<TPropertyValue> BuildTPropertyValues()
        {
            var allSettableProperties = SetablePropertiesList().Select(x => x.Name).ToList();
            return BuildTPropertyValues(allSettableProperties);
        }

        /// <summary>
        /// Returns a list of TPropertyValue for updating IceWarp.
        /// <para>All public settable properties from the property names will be included unless they have a value of null.</para>
        /// </summary>
        /// <param name="propertyNames">List of property names</param>
        /// <returns>The list of settable properties. See <see cref="List{TPropertyValue}"/></returns>
        /// <exception cref="SettablePropertyException">Thrown if the property name does not exist, is not public or doesn't have a set method.</exception>
        public List<TPropertyValue> BuildTPropertyValues(List<string> propertyNames)
        {
            var items = new List<TPropertyValue>();
            foreach (var propertyName in propertyNames)
            {
                var property = ClassHelper.Property(this.GetType(), propertyName, BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public);
                if (property == null || property.SetMethod == null || !property.SetMethod.IsPublic)
                {
                    throw new SettablePropertyException(propertyName);
                }
                var value = buildTPropertyValue(property);
                if (value != null)
                {
                    items.Add(value);
                }
            }
            return items;
        }

        /// <summary>
        /// Returns a list of public property names.
        /// </summary>
        /// <returns>The public property names.</returns>
        public List<string> PropertyNamesList()
        {
            return ClassHelper.PublicProperites(this.GetType()).Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Returns a list of the properties with a public get method.
        /// </summary>
        /// <returns>The list of properties with a public get method.</returns>
        public List<PropertyInfo> GetablePropertiesList()
        {
            return ClassHelper.PublicGetProperites(this.GetType());
        }

        /// <summary>
        /// Returns a list of the properties with a public set method.
        /// </summary>
        /// <returns>The list of properties with a public set method.</returns>
        public List<PropertyInfo> SetablePropertiesList()
        {
            return ClassHelper.PublicSetProperties(this.GetType());
        }

        private TPropertyValue buildTPropertyValue(PropertyInfo property)
        {
            if (property.SetMethod != null && property.SetMethod.IsPublic)
            {
                //bool?
                //char?
                //DateTime?
                //int?
                //Enum?
                //string
                //List<string>
                var value = property.GetValue(this);
                if (value != null)
                {
                    if (property.PropertyType == typeof(bool))
                    {
                        return TPropertyValHelper.SetPropertyValue((bool)value, property.Name);
                    }
                    if (property.PropertyType == typeof(bool?))
                    {
                        return TPropertyValHelper.SetPropertyValue((bool?)value, property.Name);
                    }
                    if (property.PropertyType == typeof(char))
                    {
                        return TPropertyValHelper.SetPropertyValue((char)value, property.Name);
                    }
                    if (property.PropertyType == typeof(char?))
                    {
                        return TPropertyValHelper.SetPropertyValue((char?)value, property.Name);
                    }
                    if (property.PropertyType == typeof(int))
                    {
                        return TPropertyValHelper.SetPropertyValue((int)value, property.Name);
                    }
                    if (property.PropertyType == typeof(int?))
                    {
                        return TPropertyValHelper.SetPropertyValue((int?)value, property.Name);
                    }
                    if (property.PropertyType == typeof(DateTime))
                    {
                        return TPropertyValHelper.SetPropertyValue((DateTime)value, property.Name);
                    }
                    if (property.PropertyType == typeof(DateTime?))
                    {
                        return TPropertyValHelper.SetPropertyValue((DateTime?)value, property.Name);
                    }
                    if (property.PropertyType.IsEnum)
                    {
                        return Enum.IsDefined(property.PropertyType, value) 
                            ? TPropertyValHelper.SetPropertyValue((int)Enum.ToObject(property.PropertyType, value), property.Name) 
                            : null;
                    }
                    if (property.PropertyType.IsNullableEnum())
                    {
                        var enumType = Nullable.GetUnderlyingType(property.PropertyType);
                        return Enum.IsDefined(enumType, value)
                            ? TPropertyValHelper.SetPropertyValue((int)Enum.ToObject(enumType, value), property.Name)
                            : null;
                    }
                    if (property.PropertyType == typeof(string))
                    {
                        return TPropertyValHelper.SetPropertyValue((string)value, property.Name);
                    }
                    if (property.PropertyType == typeof(List<string>))
                    {
                        return TPropertyValHelper.SetPropertyValue((List<string>)value, property.Name);
                    }
                }
            }
            return null;
        }
    }
}
