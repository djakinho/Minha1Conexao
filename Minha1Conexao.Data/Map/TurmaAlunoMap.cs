using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data.Map
{
    public class TurmaAlunoMap : IEntityTypeConfiguration<TurmaAluno>
    {
        public void Configure(EntityTypeBuilder<TurmaAluno> builder)
        {
            builder.ToTable("TurmaAluno");

            builder.HasKey(x => new { x.IdAluno, x.IdTurma });

            builder.HasOne(t => t.Turma)
                .WithMany(ta => ta.TurmaAluno)
                .HasForeignKey(i => i.IdTurma);

            builder.HasOne(a => a.Aluno)
                .WithMany(ta => ta.TurmaAluno)
                .HasForeignKey(i => i.IdAluno);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
