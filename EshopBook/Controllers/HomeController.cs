using EshopBook.Data;
using EshopBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EshopContext _context;

        public HomeController(ILogger<HomeController> logger, EshopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.OrderByDescending(p => p.BookId).Take(4).ToList();
            var group = _context.Groups.ToList();
            var groupToBooks = _context.GroupToBooks.ToList();

            // لیست کتاب های پربازدید
            List<BestBookViewModel> book_bestview = new List<BestBookViewModel>();

            foreach (var item in group)
            {
                var best = _context.Groups
                    .Where(p => p.GroupId == item.GroupId)
                    .SelectMany(x => x.GroupToBooks)
                    .Select(x => x.Books)
                    .OrderByDescending(a => a.BookView)
                    .First();

                //var a = _context.GroupToBooks.GroupBy(p => item.GroupId).ToList();
                //var c = _context.Groups.Where(p => p.GroupId == item.GroupId).ToList();
                //var c = _context.Groups.GroupBy(p => item.GroupId).ToList();
                //var books = _context.Books.Where(a => a.BookName.Contains(bookname)).ToList();

                //var c = _context.Books.Where(a => a.GroupToBooks == item.GroupToBooks).ToList();
                //var c = _context.Groups.GroupBy(a => a.GroupToBooks).ToList();
                //int count = c.Count();
                int count = item.GroupToBooks.Count();


                book_bestview.Add(new BestBookViewModel()
                {
                    BookId = best.BookId,
                    BookName = best.BookName,
                    GroupId = _context.Groups.Where(p => p.GroupId == item.GroupId).Select(x => x.GroupId).First(),
                    Groupname = _context.Groups.Where(p => p.GroupId == item.GroupId).Select(x => x.GroupName).First(),
                    countOfBook = count
                });
            }

            var indexVM = new IndexViewModel()
            {
                Books = books,
                Group = group,
                BestBooks = book_bestview
            };

            return View(indexVM);
        }

        [Route("addbook")]
        public IActionResult AddBook()
        {
            var pubishers = _context.Publishers.ToList();
            var groups = _context.Groups.ToList();
            var bId = _context.Books.OrderByDescending(p => p.BookId).Select(p => p.BookId).First();


            var vm = new Publisher_CategoryViewModel()
            {
                Publishers = pubishers,
                Groups = groups,
                BookId = bId
            };

            return View(vm);
        }

        [HttpPost]
        [Route("addbook")]
        public IActionResult addBook(Publisher_CategoryViewModel model)
        {
            var book = new Books()
            {
                BookName = model.BookName,
                BookAuthor = model.BookAuthor,
                BookPrice = model.BookPrice,
                BookRelease = model.BookRelease,
                BookShabak = model.BookShabak,
                BookView = 0,
                PublisherId = model.PublisherId
            };
            _context.Books.Add(book);

            GroupToBook groupToBook = new GroupToBook()
            {
                GroupId = model.GroupId,
                BookId = model.BookId + 1
            };
            _context.GroupToBooks.Add(groupToBook);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult ShowBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return View("_NotFoundError");
            }

            book.BookView += 1;
            _context.SaveChanges();

            return View(book);
        }

        public IActionResult searchBook(string bookname)
        {
            var books = _context.Books.Where(a => a.BookName.Contains(bookname)).ToList();

            if (books.Count() == 0)
            {
                
                return View("_NotFoundError");
            }
                return View(books);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
