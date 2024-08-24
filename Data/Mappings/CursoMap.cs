using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Infra.Mappings
{
    internal class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder
                 .HasKey(c => c.Id);

            builder
                .Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .HasMany(c => c.Matriculas)
                .WithOne(m => m.Curso)
                .HasForeignKey(m => m.CursoId);

            builder
                .HasOne(c => c.Professor)
                .WithMany(p => p.Cursos)
                .HasForeignKey(c => c.ProfessorId);
        }
    }
}
