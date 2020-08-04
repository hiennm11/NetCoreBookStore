using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;
using NetCoreBookStore.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private const int _recordsPerLoad = 8;

        public HomeController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
            ViewBag.RecordsPerLoad = _recordsPerLoad;
        }

        public async Task<IActionResult> Index(int? page)
        {
            page = page ?? 1;
            ViewBag.IsEndOfRecords = false;
            if (CoreExtension.IsAjaxRequest(Request))
            {
                var items = await _bookRepository.GetDictionaryPagingAsync(page.Value, _recordsPerLoad);
                ViewBag.IsEndOfRecords = ((page.Value * _recordsPerLoad) >= items.Last().Key);
                return PartialView("_BookItemsDiv", items);
            }
            else
            {
                ViewBag.Recommended = await _bookRepository.GetRecomendedBooksAsync();
                ViewBag.Items = await _bookRepository.GetDictionaryPagingAsync(page.Value, _recordsPerLoad);
                return View("Index");
            }

        }

    }
}
