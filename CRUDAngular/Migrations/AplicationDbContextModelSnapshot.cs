﻿// <auto-generated />
using CRUDAngular;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDAngular.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUDAngular.Models.TarjetaDeCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TarjetaDeCreditoId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("FechaExpiracion")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("NumeroDeTarjeta")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TarjetasDeCredito");
                });
#pragma warning restore 612, 618
        }
    }
}
