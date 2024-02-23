﻿// <auto-generated />
using AndrewGardanier_Mission_6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndrewGardanier_Mission_6.Migrations
{
    [DbContext(typeof(EnterMovieContext))]
    partial class EnterMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("AndrewGardanier_Mission_6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("AndrewGardanier_Mission_6.Models.MovieInfo", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("CopiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryId");

                    b.ToTable("MovieInfo");
                });

            modelBuilder.Entity("AndrewGardanier_Mission_6.Models.MovieInfo", b =>
                {
                    b.HasOne("AndrewGardanier_Mission_6.Models.Category", "CategoryName")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryName");
                });
#pragma warning restore 612, 618
        }
    }
}
