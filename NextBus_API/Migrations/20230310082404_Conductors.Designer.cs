﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NextBus_API.Data;

#nullable disable

namespace NextBus_API.Migrations
{
    [DbContext(typeof(NextBusDbContext))]
    [Migration("20230310082404_Conductors")]
    partial class Conductors
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NextBus_API.Models.Entities.BusOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BusOwnerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfBuses")
                        .HasColumnType("int");

                    b.Property<string>("RegDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusOwners");
                });

            modelBuilder.Entity("NextBus_API.Models.Entities.Conductor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BusOwnerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BusOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConductorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusOwnerId");

                    b.ToTable("Conductors");
                });

            modelBuilder.Entity("NextBus_API.Models.Entities.Conductor", b =>
                {
                    b.HasOne("NextBus_API.Models.Entities.BusOwner", "BusOwner")
                        .WithMany()
                        .HasForeignKey("BusOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusOwner");
                });
#pragma warning restore 612, 618
        }
    }
}
