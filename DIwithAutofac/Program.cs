using Autofac;
using DIwithAutofac;

var Container = ContainerConfig.Configure();
using(var scope = Container.BeginLifetimeScope())
{
    var app = scope.Resolve<IApplication>();
    app.Run();
}
Console.WriteLine();
