using EjemploAyuda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjemploAyuda.Infraestructure.EntityConfigurations
{
    public class TutorialEntityConfiguration : IEntityTypeConfiguration<Tutorial>
    {
        public void Configure(EntityTypeBuilder<Tutorial> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).HasMaxLength(100).IsRequired();
            builder.ToTable("Tuto", "admin");
        }
    }
}