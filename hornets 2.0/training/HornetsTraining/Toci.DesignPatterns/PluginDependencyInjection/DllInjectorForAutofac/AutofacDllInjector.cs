﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;

namespace Toci.DesignPatterns.PluginDependencyInjection.DllInjectorForAutofac
{
    public class AutofacDllInjector : IDiDllInjector
    {
        private const string NameOfTypeContainsDependancies = "Register";
        private const string NameOfMethodReturnDependancies = "GetTypesToRegister";
        private const string PathPrefix = "../../../";
        private const string PathMidfix = "/bin/Debug/";
        private const string PathPostfix = ".dll";
        private const string Seperator = ".";

        private Dictionary<Type, Type> _typesToRegister;

        public void InjectDll(string name)
        {
            Assembly assembly = Assembly.LoadFrom(PathPrefix + name + PathMidfix + name + PathPostfix);

            _typesToRegister = (Dictionary<Type, Type>)assembly.
                GetType(name + Seperator + NameOfTypeContainsDependancies).
                GetMethod(NameOfMethodReturnDependancies).
                Invoke(null, null);
        }

        public void RegisterDependencies(object register)
        {
            ContainerBuilder builder = (ContainerBuilder)register;

            foreach (var type in _typesToRegister)
            {
                builder.RegisterType(type.Value).As(type.Key);
            }
        }
    }
}