﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prospecto.DATA;

namespace Prospecto.DATA.Migrations
{
    [DbContext(typeof(ProveedoresContext))]
    partial class ProveedoresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proveedores.Entidades.ProspectoEntity", b =>
                {
                    b.Property<int>("IdProspecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                   

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Colonia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");


                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumeroExterior")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SegundoApellido")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdProspecto");

                    b.ToTable("Prospecto");
                });
#pragma warning restore 612, 618
        }
    }
}