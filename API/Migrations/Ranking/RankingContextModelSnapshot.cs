﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_RankHub.Migrations.Ranking
{
    [DbContext(typeof(RankingContext))]
    partial class RankingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("API_RankHub.Models.Ranking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("UserForeignKey")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tittle")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserForeignKey");

                    b.ToTable("Ranking");
                });

            modelBuilder.Entity("API_RankHub.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("API_RankHub.Models.Ranking", b =>
                {
                    b.HasOne("API_RankHub.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserForeignKey");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
