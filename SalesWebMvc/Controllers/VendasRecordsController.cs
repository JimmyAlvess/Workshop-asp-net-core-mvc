using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class VendasRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscaSimples()
        {
            return View();
        }
        public IActionResult AgrupamentoSimples()
        {
            return View();
        }
    }
}
