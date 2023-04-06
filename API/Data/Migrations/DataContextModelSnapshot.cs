﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("API.Entities.FileData", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileExtension")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("MimeType")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("FileId");

                    b.ToTable("FileDatas");
                });
#pragma warning restore 612, 618
        }
    }
}