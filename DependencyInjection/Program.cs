using DependencyInjection.Factory;
using DependencyInjection.InterfaceFactory;
using DependencyInjection.Model;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            
            // Register interface and classes
            builder.Services.AddScoped<IEmployeeDetails, EmployeeService>();
            builder.Services.AddTransient<IProduct, ProductService>();
            builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.json",
                                   optional: false, //file is not optional
                                   reloadOnChange: true);
            });
            builder.Services.Configure<MyJson>(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.MapControllerRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "User", action = "home" }
            );
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}