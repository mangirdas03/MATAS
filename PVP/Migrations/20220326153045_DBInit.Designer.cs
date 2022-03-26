﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PVP.Models;

namespace PVP.Migrations
{
    [DbContext(typeof(PVPContext))]
    [Migration("20220326153045_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("PVP.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("pass_hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id")
                        .HasName("id");

                    b.HasIndex("mail")
                        .HasDatabaseName("Email");

                    b.HasIndex("pass_hash")
                        .HasDatabaseName("Pass_hash");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
