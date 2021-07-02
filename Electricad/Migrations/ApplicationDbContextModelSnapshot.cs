﻿// <auto-generated />
using System;
using Electricad.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Electricad.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Electricad.Data.About", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("about_desc")
                        .HasColumnType("text");

                    b.Property<string>("about_file")
                        .HasColumnType("text");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("tb_about");
                });

            modelBuilder.Entity("Electricad.Data.Offers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Userid")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .HasColumnType("text");

                    b.Property<int>("descount")
                        .HasColumnType("int");

                    b.Property<string>("offer_file")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("tb_offers");
                });

            modelBuilder.Entity("Electricad.Data.Portifolio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("port_file")
                        .HasColumnType("text");

                    b.Property<int?>("sector_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("sector_id");

                    b.ToTable("tb_portifolio");
                });

            modelBuilder.Entity("Electricad.Data.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dateComment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("tb_reviews");
                });

            modelBuilder.Entity("Electricad.Data.Sectors", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("tb_sectors");
                });

            modelBuilder.Entity("Electricad.Data.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("login")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PortifolioSectors", b =>
                {
                    b.Property<int>("Portifoliosid")
                        .HasColumnType("int");

                    b.Property<int>("Sectorsid")
                        .HasColumnType("int");

                    b.HasKey("Portifoliosid", "Sectorsid");

                    b.HasIndex("Sectorsid");

                    b.ToTable("PortifolioSectors");
                });

            modelBuilder.Entity("Electricad.Data.About", b =>
                {
                    b.HasOne("Electricad.Data.User", "User")
                        .WithOne("About")
                        .HasForeignKey("Electricad.Data.About", "user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Electricad.Data.Offers", b =>
                {
                    b.HasOne("Electricad.Data.User", "User")
                        .WithMany("Offers")
                        .HasForeignKey("Userid");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Electricad.Data.Portifolio", b =>
                {
                    b.HasOne("Electricad.Data.User", "User")
                        .WithMany("Portifolios")
                        .HasForeignKey("sector_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PortifolioSectors", b =>
                {
                    b.HasOne("Electricad.Data.Portifolio", null)
                        .WithMany()
                        .HasForeignKey("Portifoliosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Electricad.Data.Sectors", null)
                        .WithMany()
                        .HasForeignKey("Sectorsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Electricad.Data.User", b =>
                {
                    b.Navigation("About");

                    b.Navigation("Offers");

                    b.Navigation("Portifolios");
                });
#pragma warning restore 612, 618
        }
    }
}
