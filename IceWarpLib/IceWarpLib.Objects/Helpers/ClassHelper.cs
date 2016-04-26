﻿using System;
using System.Collections.Generic;
using System.Linq;
using IceWarpLib.Objects.Rpc.Classes;
using IceWarpLib.Objects.Rpc.Classes.Property;
using IceWarpLib.Objects.Rpc.Classes.Rule;

namespace IceWarpLib.Objects.Helpers
{
    public static class ClassHelper
    {
        private static List<ClassType> _tPropertyValClasses;
        private static List<ClassType> _tRuleConditionClasses;
        private static List<ClassType> _tRuleActionClasses; 

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
    }

    public class ClassType
    {
        public string ClassName { get; set; }
        public string AssemblyQualifiedName { get; set; }
    }
}
