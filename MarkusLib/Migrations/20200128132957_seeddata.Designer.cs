﻿// <auto-generated />
using System;
using MarkusLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarkusLib.Migrations
{
    [DbContext(typeof(LibContext))]
    [Migration("20200128132957_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarkusLib.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            author = "Fyodor Dostoyevsky",
                            summary = "One should pray for redemption, rather than punishment.",
                            title = "Brothers Kazamarov"
                        },
                        new
                        {
                            ID = 2,
                            author = " William S. Burroughs",
                            summary = "The dark and seedy underworld.",
                            title = "Naked Lunch"
                        },
                        new
                        {
                            ID = 3,
                            author = "Viktor E. Frankyl",
                            summary = "Happiness through suffering.",
                            title = "Man's Search for Meaning"
                        });
                });

            modelBuilder.Entity("MarkusLib.Models.Book", b =>
                {
                    b.HasOne("MarkusLib.Models.Book", null)
                        .WithMany("Books")
                        .HasForeignKey("BookID");
                });
#pragma warning restore 612, 618
        }
    }
}