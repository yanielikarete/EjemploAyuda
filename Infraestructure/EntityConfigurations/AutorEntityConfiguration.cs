using EjemploAyuda.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploAyuda.Infraestructure.EntityConfigurations
{
    public class AutorEntityConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Autor> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
            builder.HasMany(a => a.Tutoriales).WithOne(y => y.Autor);
        }
    }
}