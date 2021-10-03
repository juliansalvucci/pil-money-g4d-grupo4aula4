﻿// <auto-generated />
using System;
using AxMonar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AxMonar.Migrations
{
    [DbContext(typeof(AplicacionDBContext))]
    [Migration("20211002233148_MonaTest")]
    partial class MonaTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AxMonar.Models.Cuenta", b =>
                {
                    b.Property<int>("Cvu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMoneda")
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("Cvu");

                    b.HasIndex("Dni");

                    b.HasIndex("IdTipoMoneda");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("AxMonar.Models.Deposito", b =>
                {
                    b.Property<int>("IdDeposito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cvu")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.HasKey("IdDeposito");

                    b.HasIndex("Cvu");

                    b.ToTable("Deposito");
                });

            modelBuilder.Entity("AxMonar.Models.Destino", b =>
                {
                    b.Property<string>("CvuAlias")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Propietario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CvuAlias");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("AxMonar.Models.TipoMoneda", b =>
                {
                    b.Property<int>("IdTipoMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoMoneda");

                    b.ToTable("TipoMoneda");
                });

            modelBuilder.Entity("AxMonar.Models.Transferencia", b =>
                {
                    b.Property<int>("IdTransferencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cvu")
                        .HasColumnType("int");

                    b.Property<string>("CvuAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("Nota")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTransferencia");

                    b.HasIndex("Cvu");

                    b.HasIndex("CvuAlias");

                    b.ToTable("Transferencia");
                });

            modelBuilder.Entity("AxMonar.Models.Usuario", b =>
                {
                    b.Property<int>("Dni")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dni");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AxMonar.Models.Cuenta", b =>
                {
                    b.HasOne("AxMonar.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Dni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AxMonar.Models.TipoMoneda", "TipoMoneda")
                        .WithMany()
                        .HasForeignKey("IdTipoMoneda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMoneda");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AxMonar.Models.Deposito", b =>
                {
                    b.HasOne("AxMonar.Models.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("Cvu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuenta");
                });

            modelBuilder.Entity("AxMonar.Models.Transferencia", b =>
                {
                    b.HasOne("AxMonar.Models.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("Cvu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AxMonar.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("CvuAlias")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuenta");

                    b.Navigation("Destino");
                });
#pragma warning restore 612, 618
        }
    }
}
