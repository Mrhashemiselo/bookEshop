﻿// <auto-generated />
using System;
using EshopBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EshopBook.Migrations
{
    [DbContext(typeof(EshopContext))]
    [Migration("20220701084316_InitDB-mig")]
    partial class InitDBmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EshopBook.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookShabak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookView")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookAuthor = "یثربی",
                            BookName = "داستان پستچی",
                            BookPrice = 10000,
                            BookRelease = new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookShabak = "458-3-45-45879-1",
                            BookView = 0,
                            PublisherId = 1
                        },
                        new
                        {
                            BookId = 2,
                            BookAuthor = "نظری",
                            BookName = "ضد",
                            BookPrice = 15000,
                            BookRelease = new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookShabak = "458-3-47-41234-9",
                            BookView = 0,
                            PublisherId = 2
                        });
                });

            modelBuilder.Entity("EshopBook.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            GroupDescription = "یکی از پرطرفدارترین انواع کتاب ها",
                            GroupName = "Roman"
                        },
                        new
                        {
                            GroupId = 2,
                            GroupDescription = "اشعار یکی از مفهومی ترین نوع نوشته ها هستند",
                            GroupName = "شعر"
                        });
                });

            modelBuilder.Entity("EshopBook.Models.GroupToBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupToBooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            GroupId = 2
                        });
                });

            modelBuilder.Entity("EshopBook.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PubisherDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PubisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublisherEstablished")
                        .HasColumnType("datetime2");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = 1,
                            PubisherDescription = "ناشر کتاب های رمان",
                            PubisherName = "باران",
                            PublisherEstablished = new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PublisherId = 2,
                            PubisherDescription = "ناشر کتاب های شعر",
                            PubisherName = "هما",
                            PublisherEstablished = new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EshopBook.Models.Books", b =>
                {
                    b.HasOne("EshopBook.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EshopBook.Models.GroupToBook", b =>
                {
                    b.HasOne("EshopBook.Models.Books", "Books")
                        .WithMany("GroupToBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EshopBook.Models.Group", "Group")
                        .WithMany("GroupToBooks")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
