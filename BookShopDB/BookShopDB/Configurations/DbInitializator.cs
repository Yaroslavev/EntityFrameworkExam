using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopDB.Entities;

namespace BookShopDB.Configurations
{
    public class DbInitializator
    {
        public static void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Genre[]
            {
                new Genre() { GenreId = 1, Name = "Horror" },
                new Genre() { GenreId = 2, Name = "Fantasy" },
                new Genre() { GenreId = 3, Name = "Crime" },
                new Genre() { GenreId = 4, Name = "Satire" },
                new Genre() { GenreId = 5, Name = "Historical Fiction" },
                new Genre() { GenreId = 6, Name = "Alternate History" },
                new Genre() { GenreId = 7, Name = "Adventure" },
                new Genre() { GenreId = 8, Name = "Apocalyptic" },
                new Genre() { GenreId = 9, Name = "Psychological Fiction" },
                new Genre() { GenreId = 10, Name = "Comedy" },
                new Genre() { GenreId = 11, Name = "Tragedy" },
                new Genre() { GenreId = 12, Name = "Romance" },
                new Genre() { GenreId = 13, Name = "Thriller" }
            });

            modelBuilder.Entity<Production>().HasData(new Production[]
            {
                new Production() { ProductionId = 1, Name = "Penguin Random House" },
                new Production() { ProductionId = 2, Name = "Harper Collins" },
                new Production() { ProductionId = 3, Name = "Simon and Schuster" },
                new Production() { ProductionId = 4, Name = "Macmillian Publishers" },
                new Production() { ProductionId = 5, Name = "Hachette Book Group" },
                new Production() { ProductionId = 6, Name = "John Wiley and Sons" },
                new Production() { ProductionId = 7, Name = "Merriam-Webster" },
                new Production() { ProductionId = 8, Name = "Scholastic" },
                new Production() { ProductionId = 9, Name = "Pearson" },
                new Production() { ProductionId = 10, Name = "Houghton Mifflin Harcourt" }
            });

            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author() { AuthorId = 1, Name = "Hillary", Surname = "Mantel" },
                new Author() { AuthorId = 2, Name = "F. Scott", Surname = "Fitzgerald" },
                new Author() { AuthorId = 3, Name = "Bret", Surname = "Easton Ellis" },
                new Author() { AuthorId = 4, Name = "George", Surname = "Orwell" },
                new Author() { AuthorId = 5, Name = "Cormac", Surname = "McCarthy" },
                new Author() { AuthorId = 6, Name = "Harper", Surname = "Lee" },
                new Author() { AuthorId = 7, Name = "Herman", Surname = "Melville" },
                new Author() { AuthorId = 8, Name = "Ken", Surname = "Kesey" },
                new Author() { AuthorId = 9, Name = "Joseph", Surname = "Heller" },
                new Author() { AuthorId = 10, Name = "Gabriel", Surname = "García Márquez" },
                new Author() { AuthorId = 11, Name = "Nicolas", Surname = "Sparks" },
                new Author() { AuthorId = 12, Name = "Agatha", Surname = "Christie" },
                new Author() { AuthorId = 13, Name = "Stephen", Surname = "King" }
            });

            modelBuilder.Entity<Book>().HasData(new Book[]
            {
                new Book() { BookId = 1, Name = "Moby Dick", AuthorId = 7, ProductionId = 1, NumberOfPages = 378, GenreId = 7, Year = 1851, FullCost = 17.97, CostForSell = 14.97, IsContinuation = false },
                new Book() { BookId = 2, Name = "One Hundred Years of Solitude", AuthorId = 10, ProductionId = 3, NumberOfPages = 422, GenreId = 2, Year = 1967, FullCost = 30, CostForSell = 30, IsContinuation = false },
                new Book() { BookId = 3, Name = "Wolf Hall", AuthorId = 1, ProductionId = 6, NumberOfPages = 672, GenreId = 5, Year = 2009, FullCost = 19.9, CostForSell = 15.9, IsContinuation = true },
                new Book() { BookId = 4, Name = "Catch-22", AuthorId = 9, ProductionId = 4, NumberOfPages = 546, GenreId = 10, Year = 1961, FullCost = 110, CostForSell = 89, IsContinuation = false },
                new Book() { BookId = 5, Name = "To Kill a Mockingbird", AuthorId = 6, ProductionId = 5, NumberOfPages = 281, GenreId = 13, Year = 1960, FullCost = 9.99, CostForSell = 7.99, IsContinuation = false },
                new Book() { BookId = 6, Name = "American Psycho", AuthorId = 3, ProductionId = 9, NumberOfPages = 399, GenreId = 4, Year = 1991, FullCost = 12.99, CostForSell = 12.99, IsContinuation = false },
                new Book() { BookId = 7, Name = "The Road", AuthorId = 5, ProductionId = 10, NumberOfPages = 287, GenreId = 8, Year = 2006, FullCost = 12.99, CostForSell = 11.99, IsContinuation = false },
                new Book() { BookId = 8, Name = "Nineteen Eighty-Four", AuthorId = 4, ProductionId = 8, NumberOfPages = 304, GenreId = 6, Year = 1949, FullCost = 50.9, CostForSell = 49.9, IsContinuation = false },
                new Book() { BookId = 9, Name = "The Great Gatsby", AuthorId = 2, ProductionId = 2, NumberOfPages = 672, GenreId = 11, Year = 1925, FullCost = 0.99, CostForSell = 0.99, IsContinuation = false },
                new Book() { BookId = 10, Name = "One Flew Over the Cuckoo’s Nest", AuthorId = 8, ProductionId = 7, NumberOfPages = 325, GenreId = 9, Year = 1962, FullCost = 9.99, CostForSell = 8.99, IsContinuation = false },
                new Book() { BookId = 11, Name = "And Then There Were None", AuthorId = 12, ProductionId = 1, NumberOfPages = 272, GenreId = 3, Year = 1939, FullCost = 2.49, CostForSell = 2.49, IsContinuation = false },
                new Book() { BookId = 12, Name = "The Notebook", AuthorId = 11, ProductionId = 3, NumberOfPages = 227, GenreId = 12, Year = 1996, FullCost = 8.28, CostForSell = 7.99, IsContinuation = false },
                new Book() { BookId = 13, Name = "The Shining", AuthorId = 13, ProductionId = 8, NumberOfPages = 497, GenreId = 1, Year = 1977, FullCost = 9.99, CostForSell = 9.99, IsContinuation = false },
            });
        }
    }
}
