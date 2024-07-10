﻿// <auto-generated />
using System;
using AspNetCoreMvc_eTicaret_MovieSales.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreMvc_eTicaret_MovieSales.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Beşiktaş-İstanbul",
                            Email = "ali@gmail.com",
                            Name = "Ali Uçar",
                            Password = "123",
                            Phone = "533 345 56 67"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Kadıköy-İstanbul",
                            Email = "oya@gmail.com",
                            Name = "Oya Uçar",
                            Password = "123",
                            Phone = "543 345 56 67"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bakırköy-İstanbul",
                            Email = "nese@gmail.com",
                            Name = "Neşe Sever",
                            Password = "123",
                            Phone = "545 345 56 67"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Fatih-İstanbul",
                            Email = "hasan@gmail.com",
                            Name = "Hasan Kaya",
                            Password = "123",
                            Phone = "532 345 56 67"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Komik olaylar",
                            Name = "Komedi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tarihi savaşlar, kan, şiddet",
                            Name = "Savaş"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Hem romantik hem komik",
                            Name = "Romantik Komedi"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Acıklı hikayeler",
                            Name = "Dram"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Korku, gerilim",
                            Name = "Korku"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Robotlar, uzay",
                            Name = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Gerçek dışı, heyecanlı",
                            Name = "Fantastik"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Hareket, aksiyon dolu sahneler",
                            Name = "Aksiyon"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/images/filmadi.jpg");

                    b.Property<bool>("IsDiscount")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPopuler")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Bradd Pitt, Orlando Bloom",
                            Director = "Wolfgan Pettersen",
                            GenreId = 2,
                            ImageUrl = "/images/truva.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Truva",
                            Price = 350m,
                            ReleaseDate = new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 12,
                            Summary = "Tarihten Truva savaşından kesitler"
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Ananda George, Donny Alamsyah",
                            Director = "Gareth Evans",
                            GenreId = 8,
                            ImageUrl = "/images/baskin.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Baskın",
                            Price = 340m,
                            ReleaseDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 10,
                            Summary = "Operasyon timinin uyuşturucu baskınları"
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Leonardo Di Caprio, Cate Winslet",
                            Director = "James Cameron",
                            GenreId = 4,
                            ImageUrl = "/images/titanic.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Titanic",
                            Price = 320m,
                            ReleaseDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 15,
                            Summary = "Lüks Titanic gemisinin hazin öyküsü"
                        },
                        new
                        {
                            Id = 4,
                            Cast = "Bradd Pitt, Edward Norton",
                            Director = "David Lyinch",
                            GenreId = 8,
                            ImageUrl = "/images/fight.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Fight Club",
                            Price = 330m,
                            ReleaseDate = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 10,
                            Summary = "Dövüş kulübü, ilk kural bahsetmemek"
                        },
                        new
                        {
                            Id = 5,
                            Cast = "Bradd Pitt, Christoph Wals",
                            Director = "Quantin Tarantino",
                            GenreId = 2,
                            ImageUrl = "/images/soysuzlar.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Soysuzlar Çetesi",
                            Price = 310m,
                            ReleaseDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 20,
                            Summary = "2.Dünya savaşından kesitler"
                        },
                        new
                        {
                            Id = 6,
                            Cast = "Bradd Pitt, Christoph Wals",
                            Director = "Quantin Tarantino",
                            GenreId = 2,
                            ImageUrl = "/images/soysuzlar.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Soysuzlar Çetesi",
                            Price = 310m,
                            ReleaseDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 20,
                            Summary = "2.Dünya savaşından kesitler"
                        },
                        new
                        {
                            Id = 7,
                            Cast = "Bradd Pitt, Christoph Wals",
                            Director = "Quantin Tarantino",
                            GenreId = 2,
                            ImageUrl = "/images/soysuzlar.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Soysuzlar Çetesi",
                            Price = 310m,
                            ReleaseDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 20,
                            Summary = "2.Dünya savaşından kesitler"
                        },
                        new
                        {
                            Id = 8,
                            Cast = "Bradd Pitt, Christoph Wals",
                            Director = "Quantin Tarantino",
                            GenreId = 2,
                            ImageUrl = "/images/soysuzlar.jpg",
                            IsDiscount = false,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Soysuzlar Çetesi",
                            Price = 310m,
                            ReleaseDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Stock = 20,
                            Summary = "2.Dünya savaşından kesitler"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("MovieSales");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieSaleId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieSaleId");

                    b.ToTable("MovieSaleDetails");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Movie", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSale", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Models.Customer", "Customer")
                        .WithMany("MovieSales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSaleDetail", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Models.Movie", "Movie")
                        .WithMany("MovieSaleDetails")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSale", "MovieSale")
                        .WithMany("MovieSaleDetails")
                        .HasForeignKey("MovieSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("MovieSale");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Customer", b =>
                {
                    b.Navigation("MovieSales");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.Movie", b =>
                {
                    b.Navigation("MovieSaleDetails");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Models.MovieSale", b =>
                {
                    b.Navigation("MovieSaleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
