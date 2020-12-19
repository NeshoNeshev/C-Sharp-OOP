
using System;

namespace DIContainer.Modules
{
    public interface IModule
    {
        public void Configure();

        public Type GetMaping(Type type);
        public void CreateMapping<TInterface, TImplementation>();
    }
}
