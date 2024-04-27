using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using BookShopDB;

namespace BookShopApp.Entities
{
    public class ViewModel
    {
        public List<string> FindBy { get; set; }

        public ViewModel() {
            FindBy = ["Name", "Author", "Production", "Genre"];
        }

        public static void ShowBooks(DataGrid Table, BookShopDbContext DbContext)
        {
            Table.ItemsSource = DbContext.Books.
                Select(t => new { t.BookId, t.Name, t.Author, t.Production, t.NumberOfPages, t.Genre, t.Year, t.FullCost, t.CostForSell, t.IsContinuation }).ToList();
        }

        public static void Edit(DataGrid Table, BookShopDbContext DbContext)
        {
            Table.ItemsSource = DbContext.Books.ToList();
        }

        public static void FindByName(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Books
                .Select(t => new { t.BookId, t.Name, t.Author, t.Production, t.NumberOfPages, t.Genre, t.Year, t.FullCost, t.CostForSell, t.IsContinuation }).ToList()
                .Where(x => x.Name.ToLower().Contains(Search.ToLower()));
        }

        public static void FindByAuthor(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Books
                .Select(t => new { t.BookId, t.Name, t.Author, t.Production, t.NumberOfPages, t.Genre, t.Year, t.FullCost, t.CostForSell, t.IsContinuation }).ToList()
                .Where(x => x.Author.ToString().ToLower().Contains(Search.ToLower()));
        }

        public static void FindByProduction(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Books
                .Select(t => new { t.BookId, t.Name, t.Author, t.Production, t.NumberOfPages, t.Genre, t.Year, t.FullCost, t.CostForSell, t.IsContinuation }).ToList()
                .Where(x => x.Production.ToString().ToLower().Contains(Search.ToLower()));
        }

        public static void FindByGenre(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Books
                .Select(t => new { t.BookId, t.Name, t.Author, t.Production, t.NumberOfPages, t.Genre, t.Year, t.FullCost, t.CostForSell, t.IsContinuation }).ToList()
                .Where(x => x.Genre.ToString().ToLower().Contains(Search.ToLower()));
        }

        public static void FindAuthor(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Authors.Select(t => new { t.AuthorId, t.Name, t.Surname }).ToList().Where(x => $"{x.Name} {x.Surname}".Contains(Search));
        }

        public static void FindProduction(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Productions.Select(t => new { t.ProductionId, t.Name }).ToList().Where(x => x.Name.Contains(Search));
        }

        public static void FindGenre(DataGrid Table, BookShopDbContext DbContext, string Search)
        {
            Table.ItemsSource = DbContext.Genres.ToList().Where(x => x.Name.Contains(Search));
        }
    }
}
