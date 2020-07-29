using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBookStore.Core.Repositories;

namespace NetCoreBookStore.Controllers
{
    public class ShopController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public ShopController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _bookRepository.GetAllBookAsync();
            return View(response);
        }
    }
}
