using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Console
{
    public class DependencyResolver
    {
        DependencyContainer _container;

        public DependencyResolver(DependencyContainer container)
        {
            _container = container;
        }

        public T GetService<T>()
        {
            var dependency = _container.GetDependency(typeof(T));
            var constructor = dependency.GetConstructors().Single();
            var parameters = constructor.GetParameters().ToArray();

            if (parameters.Length > 0)
            {
                var parameterImplementations = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    parameterImplementations[i] = Activator.CreateInstance(parameters[i].ParameterType);
                }

                return (T)Activator.CreateInstance(dependency, parameterImplementations);
            }


            return (T)Activator.CreateInstance(dependency);
        }
    }
}
