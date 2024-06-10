﻿// <auto-generated />
using System;
using CQRS_Mediator_Car.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CQRS_Mediator_Car.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<float>("CarDayPrice")
                        .HasColumnType("real");

                    b.Property<string>("CarDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarDoor")
                        .HasColumnType("int");

                    b.Property<string>("CarFuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarInProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarLuggage")
                        .HasColumnType("int");

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarPessenger")
                        .HasColumnType("int");

                    b.Property<DateTime>("CarRentFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CarRentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureAutomaticTransmission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("FeatureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.HasIndex("CarId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Car", b =>
                {
                    b.HasOne("CQRS_Mediator_Car.DAL.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Feature", b =>
                {
                    b.HasOne("CQRS_Mediator_Car.DAL.Car", "Car")
                        .WithMany("Features")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CQRS_Mediator_Car.DAL.Car", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
