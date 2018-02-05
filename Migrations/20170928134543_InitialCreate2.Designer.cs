﻿// <auto-generated />
using coreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace coreApp.Migrations
{
    [DbContext(typeof(PhotoContext))]
    [Migration("20170928134543_InitialCreate2")]
    partial class InitialCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreApp.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Likes");

                    b.Property<string>("Src");

                    b.Property<int?>("UserId");

                    b.HasKey("PhotoId");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("coreApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PhotoId");

                    b.Property<int>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("coreApp.Models.Photo", b =>
                {
                    b.HasOne("coreApp.Models.User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
