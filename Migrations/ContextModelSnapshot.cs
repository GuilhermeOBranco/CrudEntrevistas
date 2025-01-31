﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEstags.Data;

namespace ProjetoEstags.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ProjetoEstags.Models.Entrevista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Andamento")
                        .HasColumnType("int");

                    b.Property<int>("EntrevistadoId")
                        .HasColumnType("int");

                    b.Property<int>("EntrevistadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntrevistadoId");

                    b.HasIndex("EntrevistadorId");

                    b.ToTable("Entrevista");
                });

            modelBuilder.Entity("ProjetoEstags.Models.Entrevistado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entrevistado");
                });

            modelBuilder.Entity("ProjetoEstags.Models.Entrevistador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NomeEntrevistador")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entrevistador");
                });

            modelBuilder.Entity("ProjetoEstags.Models.Entrevista", b =>
                {
                    b.HasOne("ProjetoEstags.Models.Entrevistado", "IdEntrevistado")
                        .WithMany()
                        .HasForeignKey("EntrevistadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoEstags.Models.Entrevistador", "IdEntrevistador")
                        .WithMany()
                        .HasForeignKey("EntrevistadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdEntrevistado");

                    b.Navigation("IdEntrevistador");
                });
#pragma warning restore 612, 618
        }
    }
}
