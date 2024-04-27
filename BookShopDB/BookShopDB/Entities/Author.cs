using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDB.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
