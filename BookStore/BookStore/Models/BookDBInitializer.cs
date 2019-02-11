using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookStore.Models;

namespace BookStore.Models
{
    public class BookDBInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { BookId = 1, Name = "Harry Potter and the Order of Pheonix", Author = "J. K. Rowling" });

            db.Books.Add(new Book { BookId = 2, Name = "A Dance with Dragons", Author = "George R. R. Martin" });

            base.Seed(db);
        }
    }
}