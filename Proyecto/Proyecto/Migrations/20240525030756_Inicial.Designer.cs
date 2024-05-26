﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.Data.Contexts;

#nullable disable

namespace Proyecto.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240525030756_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto.Modelos.Cliente", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDeRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Proyecto.Modelos.Historial", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LibroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LibroId");

                    b.ToTable("Historiales");
                });

            modelBuilder.Entity("Proyecto.Modelos.Libro", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Año")
                        .HasColumnType("int");

                    b.Property<bool?>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Proyecto.Modelos.SinDevolver", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LibroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LibroId");

                    b.ToTable("SinDevolvers");
                });

            modelBuilder.Entity("Proyecto.Modelos.Historial", b =>
                {
                    b.HasOne("Proyecto.Modelos.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Proyecto.Modelos.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId");

                    b.Navigation("Cliente");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("Proyecto.Modelos.SinDevolver", b =>
                {
                    b.HasOne("Proyecto.Modelos.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Proyecto.Modelos.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId");

                    b.Navigation("Cliente");

                    b.Navigation("Libro");
                });
#pragma warning restore 612, 618
        }
    }
}
