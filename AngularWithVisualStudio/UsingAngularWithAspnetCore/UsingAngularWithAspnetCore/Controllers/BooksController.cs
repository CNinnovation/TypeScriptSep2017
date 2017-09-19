using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UsingAngularWithAspnetCore.Models;

namespace UsingAngularWithAspnetCore.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Book> SampleBooks()
        {
            Thread.Sleep(3000);

            return new List<Book>
            {
                new Book { BookId = 1, Title = "Learning TypeScript", Publisher="Packt"},
                new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"}
            };
        }
    }
}
