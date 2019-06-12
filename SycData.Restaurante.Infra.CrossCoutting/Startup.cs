using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.CrossCoutting
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{

        //    // Get our http configuration
        //    var config = new HttpConfiguration();

        //    // Register the Autofac middleware FIRST. This also adds
        //    // Autofac-injected middleware registered with the container.
        //    var container = ConfigureInversionOfControl(app, config);

        //    // Register all areas
        //    AreaRegistration.RegisterAllAreas();
        //    GlobalConfiguration.Configure(WebApiConfig.Register);

        //    // Use our web api
        //    app.UseWebApi(config);
        //}

        ///// <summary>
        ///// Configures Autofac DI/IoC
        ///// </summary>
        ///// <param name="app"></param>
        ///// <param name="config"></param>
        //private IContainer ConfigureInversionOfControl(IAppBuilder app, HttpConfiguration config)
        //{

        //    // Create our container
        //    var builder = new ContainerBuilder();

        //    // You can register controllers all at once using assembly scanning...
        //    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        //    // Register our module
        //    builder.RegisterModule(new AutofacModule());

        //    // Build
        //    var container = builder.Build();

        //    // Lets Web API know it should locate services using the AutofacWebApiDependencyResolver
        //    config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        //    // Return our container
        //    return container;
        //}
    }
}
