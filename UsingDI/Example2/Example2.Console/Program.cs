using Example2.Console;

var container = new DependencyContainer();
container.AddDependency<HelloService>();
container.AddDependency<ServiceConsumer>();

var resolver = new DependencyResolver(container);

var consumer = resolver.GetService<ServiceConsumer>();

consumer.Print();
