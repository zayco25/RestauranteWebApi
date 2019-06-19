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


            container.RegisterType<IProducto, ProductoRepository>();
            container.RegisterType<IProductoService, ProductoService>();

            container.RegisterType<IRegostroPedidoService, RegistroPedidoService>();
            container.RegisterType<IComandaService, ComandaService>();
            container.RegisterType<IComanda, ComandaRepository>();
            container.RegisterType<IRegistroPedido, RegistroPedidoRepository>();
            container.RegisterType<IComandaDetalle, DetalleComandaRepository>();




            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}