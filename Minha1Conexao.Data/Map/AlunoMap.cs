using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;

namespace Minha1Conexao.Data.Map
{
    class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.HasOne(x => x.Turma)
                .WithMany(x => x.Alunos)
                .HasForeignKey(x => x.IdTurma);
        }
    }
}
