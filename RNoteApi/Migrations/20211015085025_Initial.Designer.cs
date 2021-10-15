﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RNoteApi.Data;

namespace RNoteApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211015085025_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RNoteApi.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            CreateTime = new DateTime(2021, 10, 15, 11, 50, 25, 2, DateTimeKind.Local).AddTicks(7831),
                            Title = "Sample Note 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Sed sit amet risus nec enim molestie consectetur.",
                            CreateTime = new DateTime(2021, 10, 15, 11, 50, 25, 4, DateTimeKind.Local).AddTicks(5267),
                            Title = "Sample Note 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
