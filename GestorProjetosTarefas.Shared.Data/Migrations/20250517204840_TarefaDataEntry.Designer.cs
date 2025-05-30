﻿// <auto-generated />
using GestorProjetosTarefas.Shared.Data.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestorProjetosTarefas.Shared.Data.Migrations
{
    [DbContext(typeof(GestorProjetosTarefasContext))]
    [Migration("20250517204840_TarefaDataEntry")]
    partial class TarefaDataEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestorProjetosTarefas.Shared.Models.Empregado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empregado");
                });

            modelBuilder.Entity("GestorProjetosTarefas.Shared.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DuracaoDias")
                        .HasColumnType("int");

                    b.Property<int?>("EmpregadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpregadoId");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("GestorProjetosTarefas.Shared.Models.Tarefa", b =>
                {
                    b.HasOne("GestorProjetosTarefas.Shared.Models.Empregado", "Empregado")
                        .WithMany("Tarefa")
                        .HasForeignKey("EmpregadoId");

                    b.Navigation("Empregado");
                });

            modelBuilder.Entity("GestorProjetosTarefas.Shared.Models.Empregado", b =>
                {
                    b.Navigation("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
