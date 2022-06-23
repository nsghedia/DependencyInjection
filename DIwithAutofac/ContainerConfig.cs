using Autofac;
using System.Reflection;

namespace DIwithAutofac
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            //builder.RegisterType<BL>().As<IBL>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DIwithAutofac)))
                .Where(t =>
                {
                    string @namespace = t.Namespace ?? "";
                    return @namespace.Contains("Utilities");
                })
                .As(t => t.GetInterfaces().FirstOrDefault(i =>
                {
                    return i.Name == "I" + t.Name;
                }));
            return builder.Build();
        }
    }
}
