﻿// <auto-generated />
using System;
using BasicTournament_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasicTournament_System.Migrations
{
    [DbContext(typeof(BasicTournament_SystemContext))]
    partial class BasicTournament_SystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BasicTournament_System.Models.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<string>("EntradaPublico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Fase")
                        .HasColumnType("int");

                    b.Property<string>("Ginasio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesGerais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<string>("SobreEvento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Campeonato");
                });
#pragma warning restore 612, 618
        }
    }
}
