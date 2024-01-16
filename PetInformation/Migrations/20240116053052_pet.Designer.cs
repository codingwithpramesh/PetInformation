﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetInformation.Models;

namespace PetInformation.Migrations
{
    [DbContext(typeof(PetDbContext))]
    [Migration("20240116053052_pet")]
    partial class pet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PetInformation.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("PetId");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
