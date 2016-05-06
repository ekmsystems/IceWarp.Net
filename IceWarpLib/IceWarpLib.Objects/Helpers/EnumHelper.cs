using System;

namespace IceWarpLib.Objects.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Parses a string to an enum.
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="value">The value to parse</param>
        /// <returns>The parsed value or the default value of the enum if the value cannot be parsed.</returns>
        public static T Parse<T>(string value) where T : struct
        {
            if (!String.IsNullOrEmpty(value))
            {
                if (Enum.IsDefined(typeof (T), value))
                    return (T) Enum.Parse(typeof (T), value);

                int num;
                if (int.TryParse(value, out num))
                {
                    if (Enum.IsDefined(typeof (T), num))
                        return (T) Enum.ToObject(typeof (T), num);
                }
            }
            return default(T);
        }

        /// <summary>
        /// Parses an int to an enum.
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="value">The value to parse</param>
        /// <returns>The parsed value or the default value of the enum if the value cannot be parsed.</returns>
        public static T Parse<T>(int? value) where T : struct
        {
            if (value.HasValue)
            {
                if (Enum.IsDefined(typeof(T), value.Value))
                    return (T)Enum.ToObject(typeof(T), value.Value);
            }
            return default(T);
        }

        /// <summary>
        /// Parses a string to an enum.
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="value">The value to parse</param>
        /// <returns>The parsed value or null if the value cannot be parsed.</returns>
        public static T? ParseNullable<T>(string value) where T : struct
        {
            if (!String.IsNullOrEmpty(value))
            {
                if (Enum.IsDefined(typeof(T), value))
                    return (T)Enum.Parse(typeof(T), value);

                int num;
                if (int.TryParse(value, out num))
                {
                    if (Enum.IsDefined(typeof(T), num))
                        return (T)Enum.ToObject(typeof(T), num);
                }
            }
            return null;
        }

        /// <summary>
        /// Parses an int to an enum.
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="value">The value to parse</param>
        /// <returns>The parsed value or null if the value cannot be parsed.</returns>
        public static T? ParseNullable<T>(int? value) where T : struct
        {
            if (value.HasValue)
            {
                if (Enum.IsDefined(typeof(T), value.Value))
                    return (T)Enum.ToObject(typeof(T), value.Value);
            }
            return null;
        }

        /// <summary>
        /// Checks if a Type is a Nullable Enum
        /// </summary>
        /// <param name="t">The type. See <see cref="Type"/></param>
        /// <returns>True if the type is Nullable Enum</returns>
        public static bool IsNullableEnum(this Type t)
        {
            Type u = Nullable.GetUnderlyingType(t);
            return (u != null) && u.IsEnum;
        }
    }
}
