using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;

namespace NetCoreBookStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public ProductController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public async Task<IActionResult> List()
        {
            var response = await _bookRepository.GetAllAsync();
            return View(response);
        }

        public async Task<IActionResult> Details(string id)
        {
            var response = await _bookRepository.GetSingleAsync(id);
            ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
            return View(response);
        }
    }
}
