using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Controllers
{
    public class HomeContoller: Controller
    {
        public String Index()
        {
            return "WebGentle";
        }
    }
}
