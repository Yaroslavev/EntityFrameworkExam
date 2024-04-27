﻿// <auto-generated />
using BookShopDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShopDB.Migrations
{
    [DbContext(typeof(BookShopDbContext))]
    [Migration("20240425181739_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShopDB.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "Hillary",
                            Surname = "Mantel"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "F. Scott",
                            Surname = "Fitzgerald"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Bret",
                            Surname = "Easton Ellis"
                        },
                        new
                        {
                            AuthorId = 4,
                            Name = "George",
                            Surname = "Orwell"
                        },
                        new
                        {
                            AuthorId = 5,
                            Name = "Cormac",
                            Surname = "McCarthy"
                        },
                        new
                        {
                            AuthorId = 6,
                            Name = "Harper",
                            Surname = "Lee"
                        },
                        new
                        {
                            AuthorId = 7,
                            Name = "Herman",
                            Surname = "Melville"
                        },
                        new
                        {
                            AuthorId = 8,
                            Name = "Ken",
                            Surname = "Kesey"
                        },
                        new
                        {
                            AuthorId = 9,
                            Name = "Joseph",
                            Surname = "Heller"
                        },
                        new
                        {
                            AuthorId = 10,
                            Name = "Gabriel",
                            Surname = "García Márquez"
                        },
                        new
                        {
                            AuthorId = 11,
                            Name = "Nicolas",
                            Surname = "Sparks"
                        },
                        new
                        {
                            AuthorId = 12,
                            Name = "Agatha",
                            Surname = "Christie"
                        },
                        new
                        {
                            AuthorId = 13,
                            Name = "Stephen",
                            Surname = "King"
                        });
                });

            modelBuilder.Entity("BookShopDB.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("Author");

                    b.Property<double>("CostForSell")
                        .HasColumnType("float")
                        .HasColumnName("Selling cost, $");

                    b.Property<double>("FullCost")
                        .HasColumnType("float")
                        .HasColumnName("Original cost, $");

                    b.Property<int>("GenreId")
                        .HasColumnType("int")
                        .HasColumnName("Genre");

                    b.Property<bool>("IsContinuation")
                        .HasColumnType("bit")
                        .HasColumnName("Is continuation?");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int")
                        .HasColumnName("Number of pages");

                    b.Property<int>("ProductionId")
                        .HasColumnType("int")
                        .HasColumnName("Production");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("ProductionId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 7,
                            CostForSell = 14.970000000000001,
                            FullCost = 17.969999999999999,
                            GenreId = 7,
                            IsContinuation = false,
                            Name = "Moby Dick",
                            NumberOfPages = 378,
                            ProductionId = 1,
                            Year = 1851
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 10,
                            CostForSell = 30.0,
                            FullCost = 30.0,
                            GenreId = 2,
                            IsContinuation = false,
                            Name = "One Hundred Years of Solitude",
                            NumberOfPages = 422,
                            ProductionId = 3,
                            Year = 1967
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 1,
                            CostForSell = 15.9,
                            FullCost = 19.899999999999999,
                            GenreId = 5,
                            IsContinuation = true,
                            Name = "Wolf Hall",
                            NumberOfPages = 672,
                            ProductionId = 6,
                            Year = 2009
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 9,
                            CostForSell = 89.0,
                            FullCost = 110.0,
                            GenreId = 10,
                            IsContinuation = false,
                            Name = "Catch-22",
                            NumberOfPages = 546,
                            ProductionId = 4,
                            Year = 1961
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 6,
                            CostForSell = 7.9900000000000002,
                            FullCost = 9.9900000000000002,
                            GenreId = 13,
                            IsContinuation = false,
                            Name = "To Kill a Mockingbird",
                            NumberOfPages = 281,
                            ProductionId = 5,
                            Year = 1960
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 3,
                            CostForSell = 12.99,
                            FullCost = 12.99,
                            GenreId = 4,
                            IsContinuation = false,
                            Name = "American Psycho",
                            NumberOfPages = 399,
                            ProductionId = 9,
                            Year = 1991
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 5,
                            CostForSell = 11.99,
                            FullCost = 12.99,
                            GenreId = 8,
                            IsContinuation = false,
                            Name = "The Road",
                            NumberOfPages = 287,
                            ProductionId = 10,
                            Year = 2006
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 4,
                            CostForSell = 49.899999999999999,
                            FullCost = 50.899999999999999,
                            GenreId = 6,
                            IsContinuation = false,
                            Name = "Nineteen Eighty-Four",
                            NumberOfPages = 304,
                            ProductionId = 8,
                            Year = 1949
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 2,
                            CostForSell = 0.98999999999999999,
                            FullCost = 0.98999999999999999,
                            GenreId = 11,
                            IsContinuation = false,
                            Name = "The Great Gatsby",
                            NumberOfPages = 672,
                            ProductionId = 2,
                            Year = 1925
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 8,
                            CostForSell = 8.9900000000000002,
                            FullCost = 9.9900000000000002,
                            GenreId = 9,
                            IsContinuation = false,
                            Name = "One Flew Over the Cuckoo’s Nest",
                            NumberOfPages = 325,
                            ProductionId = 7,
                            Year = 1962
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 12,
                            CostForSell = 2.4900000000000002,
                            FullCost = 2.4900000000000002,
                            GenreId = 3,
                            IsContinuation = false,
                            Name = "And Then There Were None",
                            NumberOfPages = 272,
                            ProductionId = 1,
                            Year = 1939
                        },
                        new
                        {
                            BookId = 12,
                            AuthorId = 11,
                            CostForSell = 7.9900000000000002,
                            FullCost = 8.2799999999999994,
                            GenreId = 12,
                            IsContinuation = false,
                            Name = "The Notebook",
                            NumberOfPages = 227,
                            ProductionId = 3,
                            Year = 1996
                        },
                        new
                        {
                            BookId = 13,
                            AuthorId = 13,
                            CostForSell = 9.9900000000000002,
                            FullCost = 9.9900000000000002,
                            GenreId = 1,
                            IsContinuation = false,
                            Name = "The Shining",
                            NumberOfPages = 497,
                            ProductionId = 8,
                            Year = 1977
                        });
                });

            modelBuilder.Entity("BookShopDB.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Fantasy"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Crime"
                        },
                        new
                        {
                            GenreId = 4,
                            Name = "Satire"
                        },
                        new
                        {
                            GenreId = 5,
                            Name = "Historical Fiction"
                        },
                        new
                        {
                            GenreId = 6,
                            Name = "Alternate History"
                        },
                        new
                        {
                            GenreId = 7,
                            Name = "Adventure"
                        },
                        new
                        {
                            GenreId = 8,
                            Name = "Apocalyptic"
                        },
                        new
                        {
                            GenreId = 9,
                            Name = "Psychological Fiction"
                        },
                        new
                        {
                            GenreId = 10,
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreId = 11,
                            Name = "Tragedy"
                        },
                        new
                        {
                            GenreId = 12,
                            Name = "Romance"
                        },
                        new
                        {
                            GenreId = 13,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("BookShopDB.Entities.Production", b =>
                {
                    b.Property<int>("ProductionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductionId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductionId");

                    b.ToTable("Productions");

                    b.HasData(
                        new
                        {
                            ProductionId = 1,
                            Name = "Penguin Random House"
                        },
                        new
                        {
                            ProductionId = 2,
                            Name = "Harper Collins"
                        },
                        new
                        {
                            ProductionId = 3,
                            Name = "Simon and Schuster"
                        },
                        new
                        {
                            ProductionId = 4,
                            Name = "Macmillian Publishers"
                        },
                        new
                        {
                            ProductionId = 5,
                            Name = "Hachette Book Group"
                        },
                        new
                        {
                            ProductionId = 6,
                            Name = "John Wiley and Sons"
                        },
                        new
                        {
                            ProductionId = 7,
                            Name = "Merriam-Webster"
                        },
                        new
                        {
                            ProductionId = 8,
                            Name = "Scholastic"
                        },
                        new
                        {
                            ProductionId = 9,
                            Name = "Pearson"
                        },
                        new
                        {
                            ProductionId = 10,
                            Name = "Houghton Mifflin Harcourt"
                        });
                });

            modelBuilder.Entity("BookShopDB.Entities.Book", b =>
                {
                    b.HasOne("BookShopDB.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopDB.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopDB.Entities.Production", "Production")
                        .WithMany("Books")
                        .HasForeignKey("ProductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");

                    b.Navigation("Production");
                });

            modelBuilder.Entity("BookShopDB.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShopDB.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShopDB.Entities.Production", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
