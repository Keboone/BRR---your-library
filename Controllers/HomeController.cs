using LibraryFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LibraryFinal.Repositories;

namespace LibraryFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllBooks()
        {
            IEnumerable<Book> books = _bookRepository.GetAll();
            return View(books);
        }

        public IActionResult BookDetails(int id)
        {
            Book? book = _bookRepository.GetBook(id);
            return View(book);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}