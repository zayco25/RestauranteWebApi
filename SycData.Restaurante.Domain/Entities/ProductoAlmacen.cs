namespace SycData.Restaurante.Infra.Persistence.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoAlmacen")]
    public partial class ProductoAlmacen
    {
        [Key]
        public int IdProductoAlmacen { get; set; }

        public int IdProducto { get; set; }

        public int IdAlmacen { get; set; }

        public double Stock { get; set; }

        public virtual Almacen Almacen { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
