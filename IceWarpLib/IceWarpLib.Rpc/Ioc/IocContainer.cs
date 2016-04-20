using StructureMap;
using StructureMap.Graph;

namespace IceWarpLib.Rpc.Ioc
{
    public static class IocContainer
    {
        private static IContainer _container;
        private static bool _isInitialised;

        public static IContainer Container()
        {
            if (!_isInitialised)
            {
                Initialise();
            }
            return _container;
        }

        public static IContainer Initialise()
        {
            _container = new Container(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            });
            _isInitialised = true;
            return _container;
        }

        public static T Resolve<T>()
        {
            return _container.GetInstance<T>();
        }

        public static T Resolve<T>(string name)
        {
            return _container.GetInstance<T>(name);
        }

        public static void BuildUp(object target)
        {
            _container.BuildUp(target);
        }

        // helper method that shows what's in the container
        public static string WhatDoIHave()
        {
            return _container.WhatDoIHave();
        }
    }
}
