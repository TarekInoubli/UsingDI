using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Console
{
    public class DependencyContainer
    {
        List<Type> _dependencies;

        public DependencyContainer()
        {
            _dependencies = new List<Type>();
        }

        public void AddDependency<T>() => _dependencies.Add(typeof(T));

        public void AddDependency(Type type) => _dependencies.Add(type);

        public Type GetDependency(Type type) =>
            _dependencies.FirstOrDefault(x => x.Name == type.Name);
    }
}
