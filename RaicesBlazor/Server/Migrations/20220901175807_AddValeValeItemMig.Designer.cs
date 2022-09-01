﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaicesBlazor.Server;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220901175807_AddValeValeItemMig")]
    partial class AddValeValeItemMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Almacen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Almacenes");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.AlmacenItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlmacenId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("MercanciaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlmacenId");

                    b.HasIndex("MercanciaId");

                    b.ToTable("AlmacenItems");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Clasificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clasificacion");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Mercancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClasificacionId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Um")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("ClasificacionId");

                    b.ToTable("Mercancia");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Recepcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("AlmacenId")
                        .HasColumnType("int");

                    b.Property<string>("Bultos")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Casilla")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Conduce")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Conocimiento")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Contrato")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Expedicion")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Factura")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Manifiesto")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_autoriza")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("P_entrega")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("P_recibe")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Partida")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Sol_compra")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("T_bultos")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("T_chapa")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("T_ci")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Transportista")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("AlmacenId");

                    b.ToTable("Recepcion");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.RecepcionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("MercanciaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("RecepcionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MercanciaId");

                    b.HasIndex("RecepcionId");

                    b.ToTable("RecepcionItem");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.TipoTProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("TipoTProducto");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.TProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<bool>("DisponibleMP")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("Preciomanoobra")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("TipoTProductoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBruto")
                        .HasColumnType("decimal(18,6)");

                    b.HasKey("Id");

                    b.HasIndex("TipoTProductoId");

                    b.ToTable("TProducto");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Vale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("AlmacenId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_autoriza")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("P_entrega")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("P_solicita")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TipoVale")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlmacenId");

                    b.ToTable("Vale");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.ValeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("MercanciaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("ValeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MercanciaId");

                    b.HasIndex("ValeId");

                    b.ToTable("ValeItem");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.AlmacenItems", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Almacen", "Almacen")
                        .WithMany()
                        .HasForeignKey("AlmacenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaicesBlazor.Shared.Modelos.Mercancia", "Mercancia")
                        .WithMany()
                        .HasForeignKey("MercanciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Almacen");

                    b.Navigation("Mercancia");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Mercancia", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Clasificacion", "Clasificacion")
                        .WithMany()
                        .HasForeignKey("ClasificacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clasificacion");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Recepcion", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Almacen", "Almacen")
                        .WithMany()
                        .HasForeignKey("AlmacenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Almacen");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.RecepcionItem", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Mercancia", "Mercancia")
                        .WithMany()
                        .HasForeignKey("MercanciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaicesBlazor.Shared.Modelos.Recepcion", "Recepcion")
                        .WithMany()
                        .HasForeignKey("RecepcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mercancia");

                    b.Navigation("Recepcion");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.TProducto", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.TipoTProducto", "TipoTProducto")
                        .WithMany()
                        .HasForeignKey("TipoTProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoTProducto");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.Vale", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Almacen", "Almacen")
                        .WithMany()
                        .HasForeignKey("AlmacenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Almacen");
                });

            modelBuilder.Entity("RaicesBlazor.Shared.Modelos.ValeItem", b =>
                {
                    b.HasOne("RaicesBlazor.Shared.Modelos.Mercancia", "Mercancia")
                        .WithMany()
                        .HasForeignKey("MercanciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RaicesBlazor.Shared.Modelos.Vale", "Vale")
                        .WithMany()
                        .HasForeignKey("ValeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mercancia");

                    b.Navigation("Vale");
                });
#pragma warning restore 612, 618
        }
    }
}
