using SycData.Restaurante.Domain.Entities;

namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EntityConfiguration;

    public partial class RestauranteModel : DbContext
    {
        public RestauranteModel()
            : base("name=RestauranteModel")
        {

            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }


        public virtual DbSet<Mesa> Mesa { get; set; }

        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<RegistroPedido> RegistroPedido { get; set; }

        public virtual DbSet<Comanda> Comanda { get; set; }

        public virtual DbSet<DetalleComanda> DetalleComanda { get; set; }
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<ConceptoSunat> ConceptoSunat { get; set; }
        public virtual DbSet<Cotizacion> Cotizacion { get; set; }
        public virtual DbSet<CotizacionCuota> CotizacionCuota { get; set; }
        public virtual DbSet<CotizacionDetalle> CotizacionDetalle { get; set; }
        public virtual DbSet<DocumentoPago> DocumentoPago { get; set; }
        public virtual DbSet<DocumentoPagoDetalle> DocumentoPagoDetalle { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaCuenta> EmpresaCuenta { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Inventariodetalle> Inventariodetalle { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Movimiento> Movimiento { get; set; }
        public virtual DbSet<MovimientoDetalle> MovimientoDetalle { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<OperacionDetalle> OperacionDetalle { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<OrdenCompraDetalle> OrdenCompraDetalle { get; set; }
        public virtual DbSet<OrdenEnvio> OrdenEnvio { get; set; }
        public virtual DbSet<OrdenEnvioDetalle> OrdenEnvioDetalle { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoAlmacen> ProductoAlmacen { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<SerieDocumentoPago> SerieDocumentoPago { get; set; }
        public virtual DbSet<SubCategoria> SubCategoria { get; set; }
        public virtual DbSet<TipoDocumentoPago> TipoDocumentoPago { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<TipoMovimientoAlmacen> TipoMovimientoAlmacen { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {


            modelBuilder.Configurations.Add(new MesaConfiguration());
            modelBuilder.Configurations.Add(new ComandaConfiguration());
            modelBuilder.Configurations.Add(new ComandaDetalleConfiguration());
            modelBuilder.Configurations.Add(new NivelConfiguration());
            modelBuilder.Configurations.Add(new RegistroPedidoConfiguration());



            modelBuilder.Entity<Almacen>()
                .Property(e => e.NombreAlmacen)
                .IsUnicode(false);

            modelBuilder.Entity<Almacen>()
                .HasMany(e => e.Inventario)
                .WithRequired(e => e.Almacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Almacen>()
                .HasMany(e => e.Movimiento)
                .WithRequired(e => e.Almacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Almacen>()
                .HasMany(e => e.ProductoAlmacen)
                .WithRequired(e => e.Almacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.NombreBanco)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.EmpresaCuenta)
                .WithRequired(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.SubCategoria)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.RazonComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Cotizacion)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.OrdenEnvio)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConceptoSunat>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConceptoSunat>()
                .Property(e => e.CodigoSunat)
                .IsUnicode(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.CotizacionCuota)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => e.IdCotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cotizacion>()
                .HasMany(e => e.CotizacionDetalle)
                .WithRequired(e => e.Cotizacion)
                .HasForeignKey(e => e.IdCotizacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentoPago>()
                .HasMany(e => e.CotizacionDetalle)
                .WithOptional(e => e.DocumentoPago)
                .HasForeignKey(e => e.DocumentoPago_IdDocumentoPago);

            modelBuilder.Entity<DocumentoPago>()
                .HasMany(e => e.DocumentoPagoDetalle)
                .WithRequired(e => e.DocumentoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RazonComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EmpresaCuenta)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Local)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaCuenta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .HasMany(e => e.Inventariodetalle)
                .WithRequired(e => e.Inventario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Local>()
                .Property(e => e.NombreLocal)
                .IsUnicode(false);

            modelBuilder.Entity<Local>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Local>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.Local)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Local>()
                .HasMany(e => e.SerieDocumentoPago)
                .WithRequired(e => e.Local)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.NombreMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Simbolo)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.CodigoSunat)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.Cotizacion)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.DocumentoPago)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.EmpresaCuenta)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.OrdenCompra)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimiento>()
                .HasMany(e => e.MovimientoDetalle)
                .WithRequired(e => e.Movimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperacionDetalle)
                .WithRequired(e => e.Operacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperacionDetalle>()
                .Property(e => e.Total)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OrdenCompra>()
                .HasMany(e => e.OrdenCompraDetalle)
                .WithRequired(e => e.OrdenCompra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdenEnvio>()
                .HasMany(e => e.OrdenEnvioDetalle)
                .WithRequired(e => e.OrdenEnvio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.CotizacionDetalle)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.DocumentoPagoDetalle)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.OrdenCompraDetalle)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoAlmacen)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.RazonComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.OrdenCompra)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SerieDocumentoPago>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<SerieDocumentoPago>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<SerieDocumentoPago>()
                .Property(e => e.RutaImpresion)
                .IsUnicode(false);

            modelBuilder.Entity<SubCategoria>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.SubCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .Property(e => e.NombreDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .HasMany(e => e.Cotizacion)
                .WithRequired(e => e.TipoDocumentoPago)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .HasMany(e => e.DocumentoPago)
                .WithRequired(e => e.TipoDocumentoPago)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .HasMany(e => e.OrdenCompra)
                .WithRequired(e => e.TipoDocumentoPago)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .HasMany(e => e.OrdenEnvio)
                .WithRequired(e => e.TipoDocumentoPago)
                .HasForeignKey(e => e.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDocumentoPago>()
                .HasMany(e => e.SerieDocumentoPago)
                .WithRequired(e => e.TipoDocumentoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoMovimientoAlmacen>()
                .HasMany(e => e.Movimiento)
                .WithRequired(e => e.TipoMovimientoAlmacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.Turno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadMedida>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.UnidadMedida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
