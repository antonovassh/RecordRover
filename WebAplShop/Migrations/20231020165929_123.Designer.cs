﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VinylRecords.Data;

#nullable disable

namespace VinylRecords.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20231020165929_123")]
    partial class _123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VinylRecords.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Categoryid")
                        .HasColumnType("int");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("orderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("plateID")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("plateID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Plate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("avaliable")
                        .HasColumnType("bit");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("longDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Plates");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.ShopCarItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ShopCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("plateid")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("plateid");

                    b.ToTable("ShopCarItem");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Category", b =>
                {
                    b.HasOne("VinylRecords.Data.Models.Category", null)
                        .WithMany("categories")
                        .HasForeignKey("Categoryid");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("VinylRecords.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VinylRecords.Data.Models.Plate", "plate")
                        .WithMany()
                        .HasForeignKey("plateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("plate");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Plate", b =>
                {
                    b.HasOne("VinylRecords.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.ShopCarItem", b =>
                {
                    b.HasOne("VinylRecords.Data.Models.Plate", "plate")
                        .WithMany()
                        .HasForeignKey("plateid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("plate");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Category", b =>
                {
                    b.Navigation("categories");
                });

            modelBuilder.Entity("VinylRecords.Data.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
