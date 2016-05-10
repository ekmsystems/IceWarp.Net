using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Classes.Rule.Actions;
using IceWarpLib.Objects.Rpc.Classes.Rule.Conditions;
using IceWarpLib.Objects.Rpc.Classes.Services;

namespace IceWarpLib.Objects.Helpers
{
    public static class ClassHelper
    {
        private static List<ClassType> _tPropertyValClasses;
        private static List<ClassType> _tRuleConditionClasses;
        private static List<ClassType> _tRuleActionClasses;
        private static List<ClassType> _tServiceStatisticsClasses;

        static ClassHelper()
        {
            _tPropertyValClasses = ReflectiveEnumerator.GetEnumerableOfType<TPropertyVal>()
                                                      .Select(x => new ClassType
                                                      {
                                                          ClassName = x.GetType().Name.ToLower(),
                                                          AssemblyQualifiedName = x.GetType().AssemblyQualifiedName
                                                      })
                                                      .OrderBy(x => x.ClassName)
                                                      .ToList();

            _tRuleActionClasses = ReflectiveEnumerator.GetEnumerableOfType<TRuleAction>()
                                                      .Select(x => new ClassType
                                                      {
                                                          ClassName = x.GetType().Name.ToLower(),
                                                          AssemblyQualifiedName = x.GetType().AssemblyQualifiedName
                                                      })
                                                      .OrderBy(x => x.ClassName)
                                                      .ToList();

            _tRuleConditionClasses = ReflectiveEnumerator.GetEnumerableOfType<TRuleCondition>()
                                                      .Select(x => new ClassType
                                                      {
                                                          ClassName = x.GetType().Name.ToLower(),
                                                          AssemblyQualifiedName = x.GetType().AssemblyQualifiedName
                                                      })
                                                      .OrderBy(x => x.ClassName)
                                                      .ToList();

            _tServiceStatisticsClasses = ReflectiveEnumerator.GetEnumerableOfType<TServiceStatistics>()
                                                      .Select(x => new ClassType
                                                      {
                                                          ClassName = x.GetType().Name.ToLower(),
                                                          AssemblyQualifiedName = x.GetType().AssemblyQualifiedName
                                                      })
                                                      .OrderBy(x => x.ClassName)
                                                      .ToList();
        }

        public static List<ClassType> TPropertyValClasses()
        {
            return _tPropertyValClasses;
        }

        public static List<ClassType> TRuleActionClasses()
        {
            return _tRuleActionClasses;
        }

        public static List<ClassType> TRuleConditionClasses()
        {
            return _tRuleConditionClasses;
        }

        public static List<ClassType> TServiceStatisticsClasses()
        {
            return _tServiceStatisticsClasses;
        }

        public static string GetMemberName<TValue>(Expression<Func<TValue>> memberAccess)
        {
            return ((MemberExpression)memberAccess.Body).Member.Name;
        }

        public static object GetInstance(string assemblyQualifiedName)
        {
            Type type = Type.GetType(assemblyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = assembly.GetType(assemblyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }

        public static object GetInstance(string assemblyQualifiedName, object[] args)
        {
            Type type = Type.GetType(assemblyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type, args);
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = assembly.GetType(assemblyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type, args);
            }
            return null;
        }
        
        public static PropertyInfo Property(Type type, string propertyName, BindingFlags bindingFlags)
        {
            return type.GetProperty(propertyName, bindingFlags);
        }

        /// <summary>
        /// Gets a list of public properties.
        /// <para>Using the following BindingFlags: Instance, Public</para>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The list of public properties. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> PublicProperites(Type type)
        {
            return Properites(type, BindingFlags.Instance | BindingFlags.Public);
        }

        /// <summary>
        /// Gets a list of properties.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>The list of properties. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> Properites(Type type, BindingFlags bindingFlags)
        {
            var props = type.GetProperties(bindingFlags).ToList();
            return props;
        }

        /// <summary>
        /// Gets a list of properties which have a public get method.
        /// <para>Using the following BindingFlags: GetProperty, Instance, Public</para>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The list of properties which have a public get method. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> PublicGetProperites(Type type)
        {
            return GetProperites(type, BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public);
        }

        /// <summary>
        /// Gets a list of properties which have a get method.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>The list of properties which have get method. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> GetProperites(Type type, BindingFlags bindingFlags)
        {
            var props = type.GetProperties(bindingFlags)
                            .Where(x => x.GetMethod != null && !x.GetMethod.IsPrivate)
                            .ToList();
            return props;
        }

        /// <summary>
        /// Gets a list of properties which have a public set method.
        /// <para>Using the following BindingFlags: SetProperty, Instance, Public.</para>
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The list of properties which have a public set method. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> PublicSetProperties(Type type)
        {
            return SetProperties(type, BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public);
        }

        /// <summary>
        /// Gets a list of properties which have a public set method.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="bindingFlags">The binding flags.</param>
        /// <returns>The list of properties which have a set method. See <see cref="List{PropertyInfo}"/></returns>
        public static List<PropertyInfo> SetProperties(Type type, BindingFlags bindingFlags)
        {
            var props = type.GetProperties(bindingFlags)
                            .Where(x => x.GetSetMethod() != null && !x.SetMethod.IsPrivate)
                            .ToList();
            return props;
        }
    }

    public class ClassType
    {
        public string ClassName { get; set; }
        public string AssemblyQualifiedName { get; set; }
    }
}
