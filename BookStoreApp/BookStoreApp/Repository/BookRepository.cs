using BookStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return Datasource();
        }
        public Book GetBookById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string authorName)
        {
            return Datasource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();

        }

        private List<Book> Datasource()
        {
            return new List<Book>()
            {
                new Book(){Id = 1, Title="MVC", Author="Charles"},
                new Book(){Id = 2, Title="C#", Author="Charles"},
                new Book(){Id = 3, Title="Java", Author="Charles"},
                new Book(){Id = 4, Title="PHP", Author="Charles"},
                new Book(){Id = 5, Title="Ruby", Author="Charles"},
            };
        }

    }
}
