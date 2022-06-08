using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasServices _vendasServices;

        public VendasController(VendasServices vendasServices)
        {
            _vendasServices = vendasServices;
        }

        public IActionResult Index()
        {
            var list = _vendasServices.FindAll();
            return View(list);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendasServices.Insert(vendedor);
            return RedirectToAction(nameof(Index));

        }
    }
}
