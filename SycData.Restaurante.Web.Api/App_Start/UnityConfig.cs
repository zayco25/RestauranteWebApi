using SycData.Restaurante.Application.Interfaces;
using SycData.Restaurante.Application.Services;
using SycData.Restaurante.Domain.Interfaces;
using SycData.Restaurante.Infra.Persistence.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace SycData.Restaurante.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();


            container.RegisterType<IUsuario, UsuarioRepository>();
            container.RegisterType<IUsuarioService, UsuarioService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}