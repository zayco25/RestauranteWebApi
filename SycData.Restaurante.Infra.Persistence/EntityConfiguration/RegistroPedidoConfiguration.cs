using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.Persistence.EntityConfiguration
{
    public class RegistroPedidoConfiguration : EntityTypeConfiguration<RegistroPedido>
    {

        public RegistroPedidoConfiguration()
        {

            this.ToTable("RegistroPedido");

            this.HasKey<int>(s => s.IdRegistroPedido);

            this.Property(x => x.IdRegistroPedido).HasDatabaseGeneratedOption(databaseGeneratedOption: System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property((x => x.FechaRegistro))
                .HasDatabaseGeneratedOption(databaseGeneratedOption: DatabaseGeneratedOption.Computed);

            //this.HasRequired<Nivel>(x => x.Nivel).WithMany(x => x.Mesas).HasForeignKey(x => x.IdNivel);

            //this.Property(x => x.Descripcion).HasMaxLength(150);
            //this.Property(x => x.Descripcion).HasColumnType("varchar");
        }

    }
}
