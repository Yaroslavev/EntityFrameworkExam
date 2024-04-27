using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDB.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; }
        public int NumberOfPages { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int Year { get; set; }
        public double FullCost { get; set; }
        public double CostForSell { get; set; }
        public bool IsContinuation { get; set; }
    }
}
