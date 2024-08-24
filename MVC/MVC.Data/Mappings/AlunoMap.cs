using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Data.Mappings
{
    internal class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasMany(a => a.Matriculas)
                .WithOne(m => m.Aluno)
                .HasForeignKey(m => m.AlunoId);
        }
    }
}
