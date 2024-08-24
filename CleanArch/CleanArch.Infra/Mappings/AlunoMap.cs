using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
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
