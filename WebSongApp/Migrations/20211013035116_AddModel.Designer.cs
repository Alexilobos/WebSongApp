﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSongApp.Data;

namespace WebSongApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211013035116_AddModel")]
    partial class AddModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebSongApp.Models.Song", b =>
                {
                    b.Property<string>("Cancion")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Letra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cancion");

                    b.ToTable("Cancion");
                });
#pragma warning restore 612, 618
        }
    }
}
