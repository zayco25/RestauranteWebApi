using SycData.Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SycData.Restaurante.Infra.Persistence.EntityConfiguration
{
  public  class MesaConfiguration: EntityTypeConfiguration<Mesa>
    {


        public MesaConfiguration()
        {
            this.ToTable("Mesa");

            this.HasKey<int>(s => s.IdMesa);

            this.Property(x => x.IdMesa).HasDatabaseGeneratedOption(databaseGeneratedOption: System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.HasRequired<Nivel>(x => x.Nivel).WithMany(x => x.Mesas).HasForeignKey(x => x.IdNivel);



            //this.Property(p => p.DateOfBirth)
            //        .HasColumnName("DoB")
            //        .HasColumnOrder(3)
            //        .HasColumnType("datetime2");

            //this.Property(p => p.StudentName)
            //        .HasMaxLength(50);

            //this.Property(p => p.StudentName)
            //        .IsConcurrencyToken();

            //this.HasMany<Course>(s => s.Courses)
            //    .WithMany(c => c.Students)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("StudentId");
            //        cs.MapRightKey("CourseId");
            //        cs.ToTable("StudentCourse");
            //    });
        }

    }
}
