using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Infra.Mappings
{
    internal class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder
            .HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
            .HasMaxLength(100);

            builder
                .Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
