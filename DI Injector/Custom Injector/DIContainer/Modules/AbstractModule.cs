

using System;
using System.Collections.Generic;

namespace DIContainer.Modules
{
     public abstract class AbstractModule:IModule
     {
         private Dictionary<Type, Type> mappings;

         public AbstractModule()
         {
             mappings= new Dictionary<Type, Type>();
             Configure();
         }
         public abstract void Configure();
       

        public Type GetMaping(Type interfaceType)
        {
            return mappings[interfaceType];
        }

        public void CreateMapping<TInterface, TImplementation>()
        {
            if (!mappings.ContainsKey(typeof(TInterface)))
            {
                mappings.Add(typeof(TInterface),typeof(TImplementation));
            }
        }
     }
}
