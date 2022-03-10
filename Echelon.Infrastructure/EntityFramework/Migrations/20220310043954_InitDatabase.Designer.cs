﻿// <auto-generated />
using Echelon.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Echelon.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220310043954_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Echelon.Core.Entities.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("AcceptsPets")
                        .HasColumnType("INTEGER")
                        .HasColumnName("accepts_pets");

                    b.Property<int>("Area")
                        .HasColumnType("INTEGER")
                        .HasColumnName("area");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("INTEGER")
                        .HasColumnName("bathrooms");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("INTEGER")
                        .HasColumnName("bedrooms");

                    b.Property<decimal>("CondominiumPrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("condominium_price");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<int>("Floor")
                        .HasColumnType("INTEGER")
                        .HasColumnName("floor");

                    b.Property<bool>("ForRent")
                        .HasColumnType("INTEGER")
                        .HasColumnName("for_rent");

                    b.Property<bool>("ForSale")
                        .HasColumnType("INTEGER")
                        .HasColumnName("for_sale");

                    b.Property<bool>("HasFurniture")
                        .HasColumnType("INTEGER")
                        .HasColumnName("has_furniture");

                    b.Property<decimal>("HomeProtectionPrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("home_protection_price");

                    b.Property<decimal>("IptuPrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("iptu_price");

                    b.Property<bool>("IsNearSubway")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_near_subway");

                    b.Property<int>("ParkingSpaces")
                        .HasColumnType("INTEGER")
                        .HasColumnName("parking_spaces");

                    b.Property<decimal>("RentPrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("rent_price");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("sale_price");

                    b.Property<int>("Suites")
                        .HasColumnType("INTEGER")
                        .HasColumnName("suites");

                    b.Property<decimal>("TenantServiceFeePrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("tenant_service_fee_price");

                    b.HasKey("Id");

                    b.ToTable("House", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}