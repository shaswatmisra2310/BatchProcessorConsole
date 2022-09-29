﻿// <auto-generated />
using DBClassLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBClassLibrary.Migrations
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20220929074722_changes")]
    partial class changes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DBClassLibrary.Models.Header", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("symbolConfigKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Key");

                    b.HasIndex("symbolConfigKey");

                    b.ToTable("HeaderTable");
                });

            modelBuilder.Entity("DBClassLibrary.Models.Quotes", b =>
                {
                    b.Property<int>("primarykey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("primarykey"), 1L, 1);

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuoteType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("primarykey");

                    b.ToTable("QuotesTable");
                });

            modelBuilder.Entity("DBClassLibrary.Models.SymbolConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SymbolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("SymbolConfigTable");
                });

            modelBuilder.Entity("DBClassLibrary.Models.Header", b =>
                {
                    b.HasOne("DBClassLibrary.Models.SymbolConfig", "symbolConfig")
                        .WithMany()
                        .HasForeignKey("symbolConfigKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("symbolConfig");
                });
#pragma warning restore 612, 618
        }
    }
}
