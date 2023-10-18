﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gameApi;

#nullable disable

namespace gameApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("gameApi.Entities.Article", b =>
                {
                    b.Property<int>("articleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("articleName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<int>("articlePrice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("scopeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("articleId");

                    b.ToTable("articles");
                });

            modelBuilder.Entity("gameApi.Entities.Attack", b =>
                {
                    b.Property<int>("attackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("defenderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("gameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("attackId");

                    b.ToTable("attacks");
                });

            modelBuilder.Entity("gameApi.Entities.Defender", b =>
                {
                    b.Property<int>("defenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("balance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("defenderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("shot")
                        .HasColumnType("INTEGER");

                    b.HasKey("defenderId");

                    b.ToTable("defenders");
                });

            modelBuilder.Entity("gameApi.Entities.Game", b =>
                {
                    b.Property<int>("gameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("cityPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("manticoraId")
                        .HasColumnType("INTEGER");

                    b.HasKey("gameId");

                    b.ToTable("games");
                });

            modelBuilder.Entity("gameApi.Entities.Manticora", b =>
                {
                    b.Property<int>("manticoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("manticoraPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("manticoraPosition")
                        .HasColumnType("INTEGER");

                    b.HasKey("manticoraId");

                    b.ToTable("manticoras");
                });

            modelBuilder.Entity("gameApi.Entities.Scope", b =>
                {
                    b.Property<int>("scopeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("scopeValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("scopeId");

                    b.ToTable("scopes");
                });

            modelBuilder.Entity("gameApi.Entities.Stock", b =>
                {
                    b.Property<int>("stockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("articleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("defenderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("stockId");

                    b.ToTable("stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
