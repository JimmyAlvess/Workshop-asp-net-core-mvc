using Microsoft.AspNetCore.Mvc;
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

    }
}
