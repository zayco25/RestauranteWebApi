using Autofac;
using Autofac.Integration.WebApi;
using SycData.Restaurante.Application.Interfaces;
using SycData.Restaurante.Application.Services;
using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SycData.Restaurante.Infra.CrossCoutting
{
    public class AutofacWebapiConfig
    {

        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterType<DBCustomerEntities>()
            //       .As<DbContext>()
            //       .InstancePerRequest();

            //builder.RegisterType<DbFactory>()
            //       .As<IDbFactory>()
            //      .InstancePerRequest();

            //builder.RegisterGeneric(typeof(GenericRepository<>))
            //       .As(typeof(IGenericRepository<>))
            //       .InstancePerRequest();

            //  builder.Register();
            builder.RegisterType<UsuarioRepository>().As<IUsuario>().InstancePerRequest();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>().InstancePerRequest();
            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

    }
}
