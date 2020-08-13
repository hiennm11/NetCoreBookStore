using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Service.Repositories;
using NetCoreBookStore.Extensions;

namespace NetCoreBookStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private const int _recordsPerLoad = 10;

        public ProductController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public async Task<IActionResult> List()
        {
            ViewBag.IsEndOfRecords = false;
            ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
            var response = await _bookRepository.GetPagingAsync(1, _recordsPerLoad);
            return View(response);
        }

        public async Task<IActionResult> Details(string id)
        {
            var response = await _bookRepository.GetSingleAsync(id);
            ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
            return View(response);
        }

        public async Task<IActionResult> LoadMore(int? page)
        {
            page = page ?? 1;
            ViewBag.IsEndOfRecords = false;
            if (CoreExtension.IsAjaxRequest(Request))
            {
                var items = await _bookRepository.GetPagingAsync(page.Value, _recordsPerLoad);
                ViewBag.IsEndOfRecords = ((page.Value * _recordsPerLoad) >= _bookRepository.TotalRow());
                return PartialView("_BookItemsDiv", items);
            }
            else
            {
                ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
                var response = await _bookRepository.GetPagingAsync(page.Value, _recordsPerLoad);
                return View("List", response);
            }
        }
    }
}
