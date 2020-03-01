﻿// <auto-generated />
using System;
using CentralErros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CentralErros.Migrations
{
    [DbContext(typeof(CentralErrosContext))]
    [Migration("20191211170122_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentralErros.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Archived")
                        .HasColumnName("archived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnName("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Environment")
                        .IsRequired()
                        .HasColumnName("environment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnName("level")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnName("origin")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("log");
                });

            modelBuilder.Entity("CentralErros.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FullName")
                        .HasColumnName("full_name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("CentralErros.Models.Log", b =>
                {
                    b.HasOne("CentralErros.Models.User", "User")
                        .WithMany("Logs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
