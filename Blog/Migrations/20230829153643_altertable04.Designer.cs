﻿// <auto-generated />
using System;
using Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20230829153643_altertable04")]
    partial class altertable04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Model.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nVARCHAR(max)");

                    b.Property<DateTime>("Creation_Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Published_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime");

                    b.HasKey("PostId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Blog.Model.PostDraft", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nVARCHAR(max)");

                    b.Property<DateTime>("Creation_Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Published_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime");

                    b.HasKey("PostId");

                    b.ToTable("PostDraft");
                });

            modelBuilder.Entity("Blog.Model.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAuthor")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoinedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
