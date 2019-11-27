﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DisCore.Shared.Events;
using DisCore.Shared.Modules;
using DisCore.Shared.Permissions;

namespace DisCore.Runner.Helpers
{
    public static class AssemblyHelper
    {
        /// <summary>
        /// Gets an IModule as a type from a given assembly, returns null if none found. 
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns>IModule type or null</returns>
        public static Type GetIModuleType(Assembly assembly)
        {
            return assembly.GetTypes().FirstOrDefault(item => item.GetInterfaces().Contains(typeof(IModule)));
        }

        /// <summary>
        /// Get all MethodInfo's that have the ListenerAttribute attribute
        /// </summary>
        /// <param name="assembly">Assembly to search</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetEventMethods(Assembly assembly)
        {
            return assembly.GetTypes().SelectMany(type => type.GetMethods()).Where(method =>
                method.GetCustomAttribute(typeof(ListenerAttribute)) != null);
        }

        /// <summary>
        /// Get types implementing T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assembly">Assembly to check types</param>
        /// <returns></returns>
        public static IEnumerable<Type> GetImplementers<T>(Assembly assembly)
        {
            return assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(T)));
        }

        /// <summary>
        /// Read an assembly into bytes then load it into the app domain
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        public static async Task<Assembly> ReadAndLoad(AppDomain domain, string location)
        {
            //Content of the assembly is loaded as bytes to prevent the DLL being locked, even if the module is unloaded after.
            var assemblyBytes = await File.ReadAllBytesAsync(location);
            return domain.Load(assemblyBytes);
        }



    }
}
