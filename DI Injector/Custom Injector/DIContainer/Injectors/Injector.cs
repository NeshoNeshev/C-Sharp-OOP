
using System;
using System.Reflection;
using DIContainer.Modules;

namespace DIContainer.Injectors
{
    public class Injector
    {
        private IModule module;
        public Injector(IModule module)
        {
            this.module = module;
        }

        public TClass Inject<TClass>()
        {
            Type classType = typeof(TClass);
            ConstructorInfo[] constructors = classType.GetConstructors();

            foreach (var constructor in constructors)
            {
                ParameterInfo[] constructorParams = constructor.GetParameters();
                object[] implementationsParams = new object[constructorParams.Length];
                int i = 0;
                foreach (var item in constructorParams)
                {
                    Type implementType = module.GetMaping(item.ParameterType);
                    implementationsParams[i++]  = Activator.CreateInstance(implementType);
                }

                return (TClass)Activator.CreateInstance(classType, implementationsParams);
            }
            return default(TClass);
        }
    }
}
