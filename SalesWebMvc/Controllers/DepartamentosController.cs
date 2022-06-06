using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento() { Id = 1, Nome = "Eletronicos" });
            list.Add(new Departamento() { Id = 2, Nome = "Acessorios" });

            return View(list);
        }
    }
}
