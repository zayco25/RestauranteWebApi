using SycData.Restaurante.Domain.Entities;
using SycData.Restaurante.Infra.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.Persistence.EntityConfiguration
{
  public  class ComandaConfiguration:EntityTypeConfiguration<Comanda>
    {

        public ComandaConfiguration()
        {
            this.ToTable("Comanda");
            this.HasKey<int>(s => s.IdComanda);
            this.Property(x => x.IdComanda).HasDatabaseGeneratedOption(databaseGeneratedOption: System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.HasRequired<Operacion>(x => x.Operacion).WithMany(x => x.Comandas).HasForeignKey(x => x.IdOperacion);

        }
    }
}
