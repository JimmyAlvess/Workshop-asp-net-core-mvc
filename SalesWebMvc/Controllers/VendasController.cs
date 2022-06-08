using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
namespace SalesWebMvc.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasServices _vendasServices;
        private readonly DepartamentoServices _departamentoServices;

        public VendasController(VendasServices vendasServices, DepartamentoServices departamentoServices)
        {
            _vendasServices = vendasServices;
            _departamentoServices = departamentoServices;

        }

        public IActionResult Index()
        {
            var list = _vendasServices.FindAll();
            return View(list);
        }
        public IActionResult Criar()
        {
            var departamentos = _departamentoServices.EncontrarTudo();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
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
