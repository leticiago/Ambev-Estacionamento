using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
