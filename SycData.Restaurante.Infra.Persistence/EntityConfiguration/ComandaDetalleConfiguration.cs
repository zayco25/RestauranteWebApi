using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.Persistence.EntityConfiguration
{
  public  class ComandaDetalleConfiguration : EntityTypeConfiguration<DetalleComanda>
    {
        public ComandaDetalleConfiguration()
        {
            this.ToTable("ComandaDetalle");
            this.HasKey<int>(s => s.IdDetalleComanda);
            this.Property(x => x.IdDetalleComanda).HasDatabaseGeneratedOption(databaseGeneratedOption: System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.HasRequired<Comanda>(x => x.Comanda).WithMany(x => x.DetalleComanda).HasForeignKey(x => x.IdComanda);

        }
    }
}
