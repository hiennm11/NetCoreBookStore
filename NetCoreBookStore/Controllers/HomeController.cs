using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Extensions;
using System.Linq;
using System.Threading.Tasks;
using NetCoreBookStore.Models;
using System.Diagnostics;

namespace NetCoreBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private const int _recordsPerLoad = 8;

        public HomeController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.IsEndOfRecords = false;
            ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
            var response = await _bookRepository.GetPagingAsync(1, _recordsPerLoad);
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
                return View("Index", response);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
