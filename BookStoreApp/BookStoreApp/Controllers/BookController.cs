using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "allbooks";
        }

        public string GetBook(int id)
        {
            return $"book with id = {id}";
        }
    }
}
