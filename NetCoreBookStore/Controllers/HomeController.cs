using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;

namespace NetCoreBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public async Task<IActionResult> Index()
        {
            var response =  await _bookRepository.GetAllAsync();
            ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
            return View(response);
        }

        public PartialViewResult LoadMoreBook(int page = 1)
        {
            return PartialView();
        }
    }
}
