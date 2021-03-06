﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minha1Conexao.Data;

namespace Minha1Conexao.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210306150326_AlunoMapMigration_Correct")]
    partial class AlunoMapMigration_Correct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Minha1Conexao.Domain.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurmaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Model.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Model.TurmaProfessor", b =>
                {
                    b.Property<int>("IdProfessor")
                        .HasColumnType("int");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("IdProfessor", "IdTurma");

                    b.HasIndex("IdTurma");

                    b.ToTable("TurmaProfessor");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Banco")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Conta")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Aluno", b =>
                {
                    b.HasOne("Minha1Conexao.Domain.Model.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaId");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Model.TurmaProfessor", b =>
                {
                    b.HasOne("Minha1Conexao.Domain.Professor", "Professor")
                        .WithMany("TurmaProfessor")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Minha1Conexao.Domain.Model.Turma", "Turma")
                        .WithMany("TurmaProfessor")
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Model.Turma", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("TurmaProfessor");
                });

            modelBuilder.Entity("Minha1Conexao.Domain.Professor", b =>
                {
                    b.Navigation("TurmaProfessor");
                });
#pragma warning restore 612, 618
        }
    }
}