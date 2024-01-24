﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace transaction.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ItemPedidoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("externalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("idPedido")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("idPedido");

                    b.ToTable("itemPedidos");
                });

            modelBuilder.Entity("PedidoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("externalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("ItemPedidoModel", b =>
                {
                    b.HasOne("PedidoModel", "pedido")
                        .WithMany("itensPedido")
                        .HasForeignKey("idPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("PedidoModel", b =>
                {
                    b.Navigation("itensPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
