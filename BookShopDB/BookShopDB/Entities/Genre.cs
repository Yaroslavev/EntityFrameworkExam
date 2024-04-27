using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopDB.Entities
{
    public class Genre
    {
        public int GenreId {  get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
